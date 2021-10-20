using Microsoft.EntityFrameworkCore;

namespace ProgrammingFAQs.Models
{
    public class FAQContext : DbContext
    {
        public FAQContext(DbContextOptions<FAQContext> options)
            : base(options)
        { }

        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Topic>().HasData(
                new Topic { TopicID = "bootstrap", Name = "Bootstrap"},
                new Topic { TopicID = "csharp", Name = "C#" },
                new Topic { TopicID = "javascript", Name = "JavaScript" }
            );
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = "general", Name = "General" },
                new Category { CategoryID = "history", Name = "History" }
                );

            modelBuilder.Entity<FAQ>().HasData(
                new { FAQID = 1, TopicID = "csharp", CategoryID = "history", Question= "Who designed the C# programming language?", Answer = "C# was designed by Anders Hejlsberg from Microsoft in 2000." },
                new { FAQID = 2, TopicID = "csharp", CategoryID = "general", Question = "Does C# allow global variables?", Answer = "No, the C# language does not allow for global variables or functions." },
                new { FAQID = 3, TopicID = "bootstrap", CategoryID = "general", Question = "Is bootstrap free?", Answer = "Yes, Bootstrap is a free and open-source CSS framework." },
                new { FAQID = 4, TopicID = "bootstrap", CategoryID = "history", Question = "When was bootstrap created?", Answer = "Bootstrap was created at Twitter in mid-2010 by Mark Otto and Jacob Thornton."},
                new { FAQID = 5, TopicID = "javascript", CategoryID = "general", Question = "Who created the JavaScript programming language?", Answer = "Brendan Eich created JavaScript in 1995." },
                new { FAQID = 6, TopicID = "javascript", CategoryID = "history", Question = "What was JavaScript originally called?", Answer = "JavaScript was originally called Mocha." }


            );
        }
    }
}
