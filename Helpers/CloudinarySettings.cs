namespace DatingApp.API.Helpers
{
    /// <summary>
    /// class representing the Cloudinary Settings
    /// </summary>
    public class CloudinarySettings
    {
        /// <summary>
        /// Name of cloud, issued by Cloudinary.
        /// </summary>
        /// <value>gets/sets string for cloudinary name</value>
        public string CloudName { get; set; }

        /// <summary>
        /// API Key of cloud, issued by Cloudinary.
        /// </summary>
        /// <value>gets/sets string for cloudinary api key</value>
        public string APIKey { get; set; }

        /// <summary>
        /// API Secret of cloud, issued by Cloudinary.
        /// </summary>
        /// <value>gets/sets string for cloudinary api secret</value>
        public string APISecret { get; set; }
    }
}