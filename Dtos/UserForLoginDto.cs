using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    /// <summary>
    /// dto for the login process
    /// </summary>
    public class UserForLoginDto
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
        public string Password { get; set; }
    }
}