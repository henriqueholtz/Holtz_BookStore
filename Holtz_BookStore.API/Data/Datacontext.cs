using Holtz_BookStore.Domain;
using Holtz_BookStore.Mapping;
using System.Data.Entity;

namespace Holtz_BookStore.API.Data
{
    public class Datacontext : DbContext
    {
        public Datacontext() : base("SQLServerConnection")
        {
                //Database.SetInitializer<BookStoreDataContext>(null);
                Configuration.LazyLoadingEnabled = false;
                Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AuthorMap());
            modelBuilder.Configurations.Add(new BookMap());
            modelBuilder.Configurations.Add(new CategoryMap());
        }
    }
}