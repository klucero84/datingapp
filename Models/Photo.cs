using System;

namespace DatingApp.API.Models
{
    /// <summary>
    /// images uploaded by the end user
    /// </summary>
    public class Photo
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public string Description { get; set; }

        public DateTime DateAdded { get; set; }

        public bool IsMain { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }
    }
}