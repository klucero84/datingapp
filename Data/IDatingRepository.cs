using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    /// <summary>
    /// Data Repository interface for dating app api
    /// </summary>
    public interface IDatingRepository
    {
        /// <summary>
        /// Adds n entity of type T
        /// </summary>
        /// <typeparam name="T">a reference type</typeparam>
         void Add<T>(T entity) where T: class;

        /// <summary>
        /// Deletes an entity of type T
        /// </summary>
        /// <typeparam name="T">a reference type</typeparam>
         void Delete<T>(T entity) where T: class;

        /// <summary>
        /// Saves all changes asynchronously
        /// </summary>
        /// <returns>an asynchronous operation returning a boolean</returns>
         Task<bool> SaveAll();

        /// <summary>
        /// Gets a list of all users asynchronously
        /// </summary>
        /// <returns>an asychronous operation returning an enumerable collection of User models</returns>
         Task<IEnumerable<User>> GetUsers();

        /// <summary>
        /// Gets a user asynchronously
        /// </summary>
        /// <param name="id">Unique identifier of the user to get</param>
        /// <returns>an asynchronous operation return a user model</returns>
         Task<User> GetUser(int id);

        /// <summary>
        /// Gets a photo asynchronously
        /// </summary>
        /// <param name="id">Unique identifer of the photo to get</param>
        /// <returns>an asynchronous operation returning a photo model</returns>
         Task<Photo> GetPhoto(int id);

        Task<Photo> GetMainPhotoForUser(int userId);
    }
}