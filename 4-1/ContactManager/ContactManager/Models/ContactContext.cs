using Microsoft.EntityFrameworkCore;

namespace ContactList.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        { }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact {
                    ContactId = 1,
                    FirstName = "Delores",
                    LastName = "Del Rio",
                    Phone = "555-987-6543",
                    Email = "delores@hotmail.com",
                    CategoryId = "1",
                    Organization = "",
                },
                new Contact
                {
                    ContactId = 2,
                    FirstName = "Efren",
                    LastName = "Herrera",
                    Phone = "555-456-7890",
                    Email = "efren@aol.com",
                    CategoryId = "2",
                    Organization = "",
                },
                new Contact
                {
                ContactId = 3,
                    FirstName = "Mary Ellen",
                    LastName = "Walton",
                    Phone = "555-123-4567",
                    Email = "MaryEllen@yahoo.com",
                    CategoryId = "3",
                    Organization = "",
                }

            );
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "1", Name = "Friend" },
                new Category { CategoryId = "2", Name = "Work" },
                new Category { CategoryId = "3", Name = "Family" }
            );
        }
    }
}