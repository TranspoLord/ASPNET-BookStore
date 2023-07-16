using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class AppDatabaseContext : DbContext
    {
        public AppDatabaseContext(DbContextOptions<AppDatabaseContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Fiction", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Non-Fiction", DisplayOrder = 2 },
                    new Category { Id = 3, Name = "Sci-Fi", DisplayOrder = 3 },
                    new Category { Id = 4, Name = "Fantasy", DisplayOrder = 4 },
                    new Category { Id = 5, Name = "Mystery", DisplayOrder = 5 },
                    new Category { Id = 6, Name = "Thriller", DisplayOrder = 6 },
                    new Category { Id = 7, Name = "Romance", DisplayOrder = 7 },
                    new Category { Id = 8, Name = "Horror", DisplayOrder = 8 },
                    new Category { Id = 9, Name = "Biography", DisplayOrder = 9 },
                    new Category { Id = 10, Name = "History", DisplayOrder = 10 },
                    new Category { Id = 11, Name = "Self-Help", DisplayOrder = 11 },
                    new Category { Id = 12, Name = "Cooking", DisplayOrder = 12 },
                    new Category { Id = 13, Name = "Travel", DisplayOrder = 13 },
                    new Category { Id = 14, Name = "Humor", DisplayOrder = 14 },
                    new Category { Id = 15, Name = "Children", DisplayOrder = 15 },
                    new Category { Id = 16, Name = "Religion", DisplayOrder = 16 },
                    new Category { Id = 17, Name = "Science", DisplayOrder = 17 },
                    new Category { Id = 18, Name = "Math", DisplayOrder = 18 },
                    new Category { Id = 19, Name = "Poetry", DisplayOrder = 19 },
                    new Category { Id = 20, Name = "Art", DisplayOrder = 20 },
                    new Category { Id = 21, Name = "Music", DisplayOrder = 21 },
                    new Category { Id = 22, Name = "Comics", DisplayOrder = 22 },
                    new Category { Id = 23, Name = "Graphic Novels", DisplayOrder = 23 },
                    new Category { Id = 24, Name = "Drama", DisplayOrder = 24 },
                    new Category { Id = 25, Name = "Action", DisplayOrder = 25 },
                    new Category { Id = 26, Name = "Adventure", DisplayOrder = 26 },
                    new Category { Id = 27, Name = "Classics", DisplayOrder = 27 },
                    new Category { Id = 28, Name = "Crime", DisplayOrder = 28 },
                    new Category { Id = 29, Name = "Detective", DisplayOrder = 29 }
                );
        }

    }
}
