using System;

namespace DatingApp.API.Models
{
    /// <summary>
    /// images uploaded by the end user
    /// </summary>
    public class Photo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string Url { get; set; }

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
        public bool IsMain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public User User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public int UserId { get; set; }
    }
}