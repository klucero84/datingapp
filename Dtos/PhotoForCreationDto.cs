using System;
using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Dtos
{
    /// <summary>
    /// dto for creating a photo
    /// </summary>
    public class PhotoForCreationDto
    {
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public IFormFile File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public DateTime DateAdded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string PublicId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PhotoForCreationDto()
        {
            DateAdded = DateTime.Now;
        }
    }
}