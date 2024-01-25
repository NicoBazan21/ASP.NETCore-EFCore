using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASP.NET_Core.Models.DBContext
{
    public class BethanysPieShopDBContext : DbContext
    {
        /// <summary>
        /// Para crear un MIGRATION y emparejar los datos con la bbdd, se hara de la siguiente manera:
        /// add-migration <name \of migration> ej: add-migration InitialMigration.
        /// Para remover una Migration hay que usar: Remove-Migration
        /// </summary>
        /// <param name="options"></param>
        public BethanysPieShopDBContext(DbContextOptions<BethanysPieShopDBContext> options) 
            : base(options)
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }

        #region OnModelCreating
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            EntityTypeBuilder<Pie> tablaPie = modelBuilder.Entity<Pie>();
               
            //Primary key
            tablaPie.HasKey(item => item.IdPie);

            tablaPie.HasOne(item => item.Category)
                    .WithMany(item => item.Pies)
                    .HasForeignKey(item => item.IdCategory)
                    .IsRequired();
            
            //Required y maxlenght
            tablaPie.Property(item => item.Name)
                    .IsRequired()
                    .HasMaxLength(120);

            tablaPie.Property(item => item.ShortDescription)
                    .HasMaxLength(200);

            tablaPie.Property(item => item.LongDescription)
                    .HasMaxLength(500);

            tablaPie.Property(item => item.AllergyInformation)
                    .HasMaxLength(500);

            EntityTypeBuilder<Category> tablaCategory = modelBuilder.Entity<Category>();

            tablaCategory.HasKey(item => item.IdCategory);

            tablaCategory.HasMany(item => item.Pies)
                         .WithOne(item => item.Category)
                         .HasForeignKey(item => item.IdPie);

            tablaCategory.Property(item => item.CategoryName)
                         .HasMaxLength(100)
                         .IsRequired();

        }*/
        #endregion
    }
}
