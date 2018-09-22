using System;
using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{

    /// <summary>
    /// dto for registation process
    /// </summary>
    public class UserForRegisterDto
    {
        /// <summary>
        /// User's name
        /// </summary>
        /// <value>gets/sets, user's name</value>
        [Required]
        public string Username { get; set; }

        /// <summary>
        /// User's password
        /// </summary>
        /// <value>gets/sets, user's password</value>
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Must be between 4 and 8 characters")]
        public string Password { get; set; }
        
        [Required]
        public string Gender { get; set; }

        [Required]
        public string KnownAs { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Country { get; set; }

        public DateTime Created { get; set; }
        
        public DateTime LastActive { get; set; }

        public UserForRegisterDto()
        {
            Created = DateTime.Now;
            LastActive = DateTime.Now;
        }
    }
}