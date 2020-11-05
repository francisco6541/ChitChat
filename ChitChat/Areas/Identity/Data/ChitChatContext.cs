using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChitChat.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ChitChat.Data
{
    public class ChitChatContext : IdentityDbContext<ChatUser>
    {
        public ChitChatContext(DbContextOptions<ChitChatContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Message>()
                .HasOne<ChatUser>(a => a.Sender)
                .WithMany(d => d.Messages)
                .HasForeignKey(d => d.UserId);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<Message> Messages { get; set; }
        public DbSet<ChatUser> User { get; set; }
    }
}
