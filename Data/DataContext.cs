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

        public DbSet<Like> Likes { get; set; }

        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Like>()
                .HasKey(k => new {k.LikerId, k.LikeeId});
             builder.Entity<Like>()
                .HasOne(u => u.Likee)
                .WithMany(u => u.Likers)
                .HasForeignKey(u => u.LikeeId)
                .OnDelete(DeleteBehavior.Restrict);
             builder.Entity<Like>()
                .HasOne(u => u.Liker)
                .WithMany(u => u.Likees)
                .HasForeignKey(u => u.LikerId)
                .OnDelete(DeleteBehavior.Restrict);
             builder.Entity<Message>()
                .HasOne(u => u.Sender)
                .WithMany(m => m.MessagesSent)
                .OnDelete(DeleteBehavior.Restrict);
             builder.Entity<Message>()
                .HasOne(u => u.Recipient)
                .WithMany(m => m.MessagesReceived)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}