using System;
using System.Collections.Generic;

namespace DatingApp.API.Models
{
    /// <summary>
    /// End user of the application
    /// </summary>
    public class User
    {
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public int Id {get; set;}

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public byte[] PasswordHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public byte[] PasswordSalt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string Gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string KnownAs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public DateTime Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public DateTime LastActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string Introduction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string LookingFor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string Interests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public ICollection<Photo> Photos { get; set; }
    }
}