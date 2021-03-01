


using AspNetCoreContentLocalization.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreContentLocalization.Data
{
    public class Storage : DbContext
    {
        public DbSet<Culture> Cultures { get; set; }
        public DbSet<LocalizationSet> LocalizationSets { get; set; }
        public DbSet<Localization> Localizations { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Library> Librarys { get; set; }

        public Storage(DbContextOptions<Storage> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Culture>(etb =>
              {
                  etb.Property(e => e.Name).IsRequired().HasMaxLength(64);
              }
            );

            modelBuilder.Entity<LocalizationSet>(etb =>
              {
              }
            );

            modelBuilder.Entity<Localization>(etb =>
              {
                  etb.HasKey(e => new { e.LocalizationSetId, e.CultureId });
              }
            );

            modelBuilder.Entity<Book>(etb =>
              {
                  etb.HasOne(x => x.Author)
                  .WithOne()
                  .OnDelete(DeleteBehavior.ClientSetNull);
                  etb.HasOne(x => x.Name)
                  .WithOne()
                  .OnDelete(DeleteBehavior.ClientSetNull);
                  etb.HasOne(x => x.Description)
                  .WithOne()
                  .OnDelete(DeleteBehavior.ClientSetNull);
              }
            );
        }
    }
}