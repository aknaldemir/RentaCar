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
        public RentContext():base("RentContext")
        {
            
        }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Arac> Araclar { get; set; }
        public DbSet<Rezervasyon> Rezervasyonlar { get; set; }
        public DbSet<Model> Modeller { get; set; }
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<Resim> Resimler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Musteri>()
                .Property(m => m.TcNo)
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
            modelBuilder.Entity<Arac>().Property(m => m.SasiNo).HasMaxLength(17).IsRequired();
            modelBuilder.Entity<Arac>().Property(m => m.Kilometre).IsRequired();
            modelBuilder.Entity<Arac>().Property(m => m.GunlukFiyat).IsRequired();
            modelBuilder.Entity<Model>().Property(m => m.ModelAdi).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Model>().Property(m => m.Yil).IsRequired();
            modelBuilder.Entity<Marka>().Property(m => m.MarkaAdi).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Resim>().Property(m => m.ResimAdi).IsRequired().HasMaxLength(50);


            base.OnModelCreating(modelBuilder);
        }
    }
}
