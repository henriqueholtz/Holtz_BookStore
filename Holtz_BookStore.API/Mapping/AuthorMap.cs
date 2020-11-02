using Holtz_BookStore.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Holtz_BookStore.Mapping
{
    public class AuthorMap : EntityTypeConfiguration<Author>
    {
        public AuthorMap()
        {
            ToTable("Author");

            HasKey(x => x.Id);
            Property(x => x.Name).HasMaxLength(60).IsRequired();

            HasMany(x => x.Books)
                .WithMany(x => x.Authors)
                .Map(x => x.ToTable("BookAuthor")); //Bond Table
        }
    }
}