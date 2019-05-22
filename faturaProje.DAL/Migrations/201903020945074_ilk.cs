namespace faturaProje.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ilk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Birim",
                c => new
                    {
                        BirimId = c.Int(nullable: false, identity: true),
                        BirimAd = c.String(),
                    })
                .PrimaryKey(t => t.BirimId);
            
            CreateTable(
                "dbo.Urun",
                c => new
                    {
                        UrunId = c.Int(nullable: false, identity: true),
                        UrunAd = c.String(),
                        BirimFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BirimId = c.Int(nullable: false),
                        KategoriId = c.Int(nullable: false),
                        KDV = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.UrunId)
                .ForeignKey("dbo.Birim", t => t.BirimId, cascadeDelete: true)
                .ForeignKey("dbo.Kategori", t => t.KategoriId, cascadeDelete: true)
                .Index(t => t.BirimId)
                .Index(t => t.KategoriId);
            
            CreateTable(
                "dbo.FaturaDetay",
                c => new
                    {
                        FaturaNo = c.Int(nullable: false),
                        UrunId = c.Int(nullable: false),
                        Adet = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Toplam = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.FaturaNo, t.UrunId })
                .ForeignKey("dbo.FaturaMaster", t => t.FaturaNo, cascadeDelete: true)
                .ForeignKey("dbo.Urun", t => t.UrunId, cascadeDelete: true)
                .Index(t => t.FaturaNo)
                .Index(t => t.UrunId);
            
            CreateTable(
                "dbo.FaturaMaster",
                c => new
                    {
                        FaturaNo = c.Int(nullable: false, identity: true),
                        MusteriId = c.Int(nullable: false),
                        Tarih = c.DateTime(nullable: false),
                        FatToplam = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.FaturaNo)
                .ForeignKey("dbo.Musteri", t => t.MusteriId, cascadeDelete: true)
                .Index(t => t.MusteriId);
            
            CreateTable(
                "dbo.Musteri",
                c => new
                    {
                        MusteriId = c.Int(nullable: false, identity: true),
                        MusteriAd = c.String(),
                        Adres = c.String(),
                        VergiDairesi = c.String(),
                        IlceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MusteriId)
                .ForeignKey("dbo.Ilce", t => t.IlceId, cascadeDelete: true)
                .Index(t => t.IlceId);
            
            CreateTable(
                "dbo.Ilce",
                c => new
                    {
                        IlceId = c.Int(nullable: false, identity: true),
                        IlceAd = c.String(),
                        IlId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IlceId)
                .ForeignKey("dbo.Il", t => t.IlId, cascadeDelete: true)
                .Index(t => t.IlId);
            
            CreateTable(
                "dbo.Il",
                c => new
                    {
                        IlId = c.Int(nullable: false, identity: true),
                        IlAd = c.String(),
                    })
                .PrimaryKey(t => t.IlId);
            
            CreateTable(
                "dbo.Kategori",
                c => new
                    {
                        KategoriId = c.Int(nullable: false, identity: true),
                        KategoriAd = c.String(),
                    })
                .PrimaryKey(t => t.KategoriId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Urun", "KategoriId", "dbo.Kategori");
            DropForeignKey("dbo.FaturaDetay", "UrunId", "dbo.Urun");
            DropForeignKey("dbo.Musteri", "IlceId", "dbo.Ilce");
            DropForeignKey("dbo.Ilce", "IlId", "dbo.Il");
            DropForeignKey("dbo.FaturaMaster", "MusteriId", "dbo.Musteri");
            DropForeignKey("dbo.FaturaDetay", "FaturaNo", "dbo.FaturaMaster");
            DropForeignKey("dbo.Urun", "BirimId", "dbo.Birim");
            DropIndex("dbo.Ilce", new[] { "IlId" });
            DropIndex("dbo.Musteri", new[] { "IlceId" });
            DropIndex("dbo.FaturaMaster", new[] { "MusteriId" });
            DropIndex("dbo.FaturaDetay", new[] { "UrunId" });
            DropIndex("dbo.FaturaDetay", new[] { "FaturaNo" });
            DropIndex("dbo.Urun", new[] { "KategoriId" });
            DropIndex("dbo.Urun", new[] { "BirimId" });
            DropTable("dbo.Kategori");
            DropTable("dbo.Il");
            DropTable("dbo.Ilce");
            DropTable("dbo.Musteri");
            DropTable("dbo.FaturaMaster");
            DropTable("dbo.FaturaDetay");
            DropTable("dbo.Urun");
            DropTable("dbo.Birim");
        }
    }
}
