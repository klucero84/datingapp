using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    /// <summary>
    /// Default DataContext
    /// </summary>
    public class DataContext : DbContext
    {

        /// <summary>
        /// End users of the application
        /// </summary>
        /// <value></value>
        public  DbSet<User> Users { get; set; }

        /// <summary>
        /// Values models
        /// </summary>
        /// <value></value>
        public DbSet<Value> Values { get; set; }

        /// <summary>
        /// constructs based on options
        /// </summary>
        /// <param name="options">options for the db context</param>
        /// <returns>a DataContext object constructed with the given options.</returns>
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
        /// <summary>
        /// images uploaded by the users
        /// </summary>
        /// <value>photo model</value>
        public DbSet<Photo> Photos { get; set; }
        
    }
}