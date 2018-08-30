using System;

namespace DatingApp.API.Dtos
{
    /// <summary>
    /// dto for photo in user detail
    /// </summary>
    public class PhotosForDetailDto
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
    }
}