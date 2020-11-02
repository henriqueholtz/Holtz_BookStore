using Holtz_BookStore.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Holtz_BookStore.Mapping
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable("Category");

            HasKey(x => x.Id);

            Property(x => x.Name).HasMaxLength(30).IsRequired();

            HasMany(x => x.Books)
                .WithRequired(x => x.Category);
        }
    }
}