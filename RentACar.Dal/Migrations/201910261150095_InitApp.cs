namespace RentACar.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitApp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Arac",
                c => new
                    {
                        AracId = c.Int(nullable: false, identity: true),
                        SasiNo = c.String(nullable: false, maxLength: 17),
                        Kilometre = c.Int(nullable: false),
                        GunlukFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ModelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AracId)
                .ForeignKey("dbo.Model", t => t.ModelId, cascadeDelete: true)
                .Index(t => t.ModelId);
            
            CreateTable(
                "dbo.Model",
                c => new
                    {
                        ModelId = c.Int(nullable: false, identity: true),
                        ModelAdi = c.String(nullable: false, maxLength: 20),
                        Yil = c.Short(nullable: false),
                        MarkaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ModelId)
                .ForeignKey("dbo.Marka", t => t.MarkaId, cascadeDelete: true)
                .Index(t => t.MarkaId);
            
            CreateTable(
                "dbo.Marka",
                c => new
                    {
                        MarkaId = c.Int(nullable: false, identity: true),
                        MarkaAdi = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.MarkaId);
            
            CreateTable(
                "dbo.Resim",
                c => new
                    {
                        ResimId = c.Int(nullable: false, identity: true),
                        ResimAdi = c.String(nullable: false, maxLength: 50),
                        AracId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ResimId)
                .ForeignKey("dbo.Arac", t => t.AracId, cascadeDelete: true)
                .Index(t => t.AracId);
            
            CreateTable(
                "dbo.Musteri",
                c => new
                    {
                        MusteriId = c.Int(nullable: false, identity: true),
                        TcNo = c.String(maxLength: 11),
                        Ad = c.String(nullable: false, maxLength: 15),
                        Soyad = c.String(nullable: false, maxLength: 20),
                        DogumTarihi = c.DateTime(nullable: false),
                        Memleket = c.String(maxLength: 15),
                        Fotokopi = c.String(),
                        Mail = c.String(nullable: false, maxLength: 50),
                        Parola = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.MusteriId);
            
            CreateTable(
                "dbo.Rezervasyon",
                c => new
                    {
                        RezervasyonId = c.Int(nullable: false, identity: true),
                        MusteriId = c.Int(nullable: false),
                        AracId = c.Int(nullable: false),
                        CikisTarihi = c.DateTime(nullable: false),
                        DonusTarihi = c.DateTime(nullable: false),
                        ToplamFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.RezervasyonId)
                .ForeignKey("dbo.Arac", t => t.AracId, cascadeDelete: true)
                .ForeignKey("dbo.Musteri", t => t.MusteriId, cascadeDelete: true)
                .Index(t => t.MusteriId)
                .Index(t => t.AracId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rezervasyon", "MusteriId", "dbo.Musteri");
            DropForeignKey("dbo.Rezervasyon", "AracId", "dbo.Arac");
            DropForeignKey("dbo.Resim", "AracId", "dbo.Arac");
            DropForeignKey("dbo.Model", "MarkaId", "dbo.Marka");
            DropForeignKey("dbo.Arac", "ModelId", "dbo.Model");
            DropIndex("dbo.Rezervasyon", new[] { "AracId" });
            DropIndex("dbo.Rezervasyon", new[] { "MusteriId" });
            DropIndex("dbo.Resim", new[] { "AracId" });
            DropIndex("dbo.Model", new[] { "MarkaId" });
            DropIndex("dbo.Arac", new[] { "ModelId" });
            DropTable("dbo.Rezervasyon");
            DropTable("dbo.Musteri");
            DropTable("dbo.Resim");
            DropTable("dbo.Marka");
            DropTable("dbo.Model");
            DropTable("dbo.Arac");
        }
    }
}
