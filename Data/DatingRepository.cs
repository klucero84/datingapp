using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    /// <summary>
    /// Imlementation of the IDatingRepository interface.
    /// </summary>
    public class DatingRepository : IDatingRepository
    {
        private readonly DataContext _context;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="context">the data context to enact upon.![CDATA[</param>
        public DatingRepository(DataContext context)
        {
            _context = context;
        }
        
        /// <summary>
        /// Creates/Adds an entity of type T to the injected data context.
        /// </summary>
        /// <typeparam name="T">a reference type</typeparam>
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        
        /// <summary>
        /// Deletes an entity of type T from the injected data context.
        /// </summary>
        /// <typeparam name="T">a reference type</typeparam>
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<Photo> GetMainPhotoForUser(int userId)
        {
            return await _context.Photos.Where(u => u.UserId == userId).FirstOrDefaultAsync();
        }

        /// <summary>
        /// Gets a photo asynchronously
        /// </summary>
        /// <param name="id">Unique identifer of the photo to get</param>
        /// <returns>an asynchronous operation returning a photo model</returns>
        public async Task<Photo> GetPhoto(int id)
        {
            var photo = await _context.Photos.FirstOrDefaultAsync(p => p.Id == id);

            return photo;
        }

        /// <summary>
        /// Returns a User for a given unique id.
        /// </summary>
        /// <param name="id">Integer value of Id of the User</param>
        /// <returns>An async operation returning a User model</returns>
        public async Task<User> GetUser(int id)
        {
            return await _context.Users.Include(p => p.Photos).FirstOrDefaultAsync(u => u.Id == id);
        }

        /// <summary>
        /// Gets all User entities in an IEnumerable Collection.
        /// </summary>
        /// <returns>an async operation return an IEnumerable of type User</returns>
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _context.Users.Include(p => p.Photos).ToListAsync();
        }

        /// <summary>
        /// Asynchronously saves all changes made in this context to the underlying database.
        /// </summary>
        /// <returns>an async operation returning an bool if any changes were saved</returns>
        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}