namespace RentACar.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTables : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Musteri", "DogumTarihi", c => c.DateTime());
            AlterColumn("dbo.Rezervasyon", "CikisTarihi", c => c.DateTime());
            AlterColumn("dbo.Rezervasyon", "DonusTarihi", c => c.DateTime());
            AlterColumn("dbo.Rezervasyon", "ToplamFiyat", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rezervasyon", "ToplamFiyat", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Rezervasyon", "DonusTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Rezervasyon", "CikisTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Musteri", "DogumTarihi", c => c.DateTime(nullable: false));
        }
    }
}
