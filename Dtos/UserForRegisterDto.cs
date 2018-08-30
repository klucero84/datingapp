using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{

    /// <summary>
    /// dto for registation process
    /// </summary>
    public class UserForRegisterDto
    {
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [Required]
        public string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Must be between 4 and 8 characters")]

        public string Password { get; set; }
    }
}