using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using DatingApp.API.Data;
using DatingApp.API.Dtos;
using DatingApp.API.Helpers;
using DatingApp.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DatingApp.API.Controllers
{
    /// <summary>
    /// Controller responsible for Photos
    /// </summary>
    [Authorize]
    [Route("api/users/{userId}/photos")]
    [ApiController]
    public class PhotosController : ControllerBase
    {
        private readonly IDatingRepository _repo;
        private readonly IMapper _mapper;
        private readonly IOptions<CloudinarySettings> _config;
        private Cloudinary _cloudinary;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="repo">data repository for application</param>
        /// <param name="mapper">mapper for dtos</param>
        /// <param name="config">configuration settings for Cloudinary</param>
        public PhotosController(IDatingRepository repo, IMapper mapper, IOptions<CloudinarySettings> config)
        {
            _repo = repo;
            _mapper = mapper;
            _config = config;
            Account acc = new Account(
                _config.Value.CloudName,
                _config.Value.APIKey,
                _config.Value.APISecret
            );

            _cloudinary = new Cloudinary(acc);
        }

        /// <summary>
        /// Reads the photo for the id
        /// </summary>
        /// <param name="id">the id of the photo retrieved</param>
        /// <returns>the photo dto for the id if photo exista</returns>
        [HttpGet("{id}", Name = "GetPhoto")]
        public async Task<IActionResult> GetPhoto(int id)
        {
            var photoFromRepo = await _repo.GetPhoto(id);
            var photo = _mapper.Map<PhotoForReturnDto>(photoFromRepo);
            return Ok(photo);
        }

        /// <summary>
        /// Creates a photo for the given user.
        /// </summary>
        /// <param name="userId">the user with which to associate the photo</param>
        /// <param name="photoDto">the photo information</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddPhotoForUser(int userId, [FromForm]PhotoForCreationDto photoDto)
        {
             if (userId != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
                return Unauthorized();

            var userFromRepo = await _repo.GetUser(userId);

            var file = photoDto.File;

            var uploadResult = new ImageUploadResult();

            //todo: add null check and message 
            if (file.Length > 0)
            {
                using(var stream = file.OpenReadStream())
                {
                    var uploadParams = new ImageUploadParams()
                    {
                        File = new FileDescription(file.Name, stream),
                        Transformation = new Transformation().Width(500).Height(500).Crop("fill").Gravity("face")
                    };

                    uploadResult = _cloudinary.Upload(uploadParams);
                }
            }

            photoDto.Url = uploadResult.Uri.ToString();
            photoDto.PublicId = uploadResult.PublicId;

            var photo = _mapper.Map<Photo>(photoDto);

            if (!userFromRepo.Photos.Any(u => u.IsMain))
                photo.IsMain = true;

            userFromRepo.Photos.Add(photo);

            

            if (await _repo.SaveAll())
            {
                PhotoForReturnDto photoToReturn = _mapper.Map<PhotoForReturnDto>(photo);
                return CreatedAtRoute("GetPhoto", new {id = photo.Id}, photoToReturn);
            }

            return BadRequest("Could not add Photo");

        }

        [HttpPut("{id}/setMain")]
        public async Task<IActionResult> SetMainPhoto(int userId, int id)
        {
            if (userId != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
                return Unauthorized();

            var user = await _repo.GetUser(userId);

            if(!user.Photos.Any(p => p.Id == id))
                return Unauthorized();

            var photoFromRepo = await _repo.GetPhoto(id);

            if (photoFromRepo.IsMain)
                return BadRequest("This is already the main photo");

            var currentMainPhoto = await _repo.GetMainPhotoForUser(userId);
            currentMainPhoto.IsMain = false;
            photoFromRepo.IsMain = true;
            if (await _repo.SaveAll())
                return NoContent();

            return BadRequest("Could not set photo to main photo");
        }
    }
}