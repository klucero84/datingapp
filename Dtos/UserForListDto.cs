using System;

namespace DatingApp.API.Dtos
{
    /// <summary>
    /// dto for listing users
    /// </summary>
    public class UserForListDto
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
        public string Gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public int Age { get; set; }

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
        public string PhotoUrl { get; set; }
    }
}