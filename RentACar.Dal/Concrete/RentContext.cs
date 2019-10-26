using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.Entity;

namespace RentACar.Dal.Concrete
{
    public class RentContext : DbContext
    {
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Arac> Araclar { get; set; }
        public DbSet<Rezervasyon> Rezervasyonlar { get; set; }
        public DbSet<Model> Modeller { get; set; }
        public DbSet<Marka> Markalar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Musteri>()
                .Property(m=>m.TcNo)
                .HasMaxLength(11);

            modelBuilder.Entity<Musteri>()
                .Property(m => m.Ad)
                .HasMaxLength(15)
                .IsRequired();

            modelBuilder.Entity<Musteri>()
                .Property(m => m.Soyad)
                .HasMaxLength(20)
                .IsRequired();

            modelBuilder.Entity<Musteri>()
                .Property(m => m.Memleket)
                .HasMaxLength(15);

            modelBuilder.Entity<Musteri>()
                .Property(m => m.Mail)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Musteri>()
                .Property(m => m.Parola)
                .HasMaxLength(20)
                .IsRequired();

            







            base.OnModelCreating(modelBuilder);
        }
    }
}
