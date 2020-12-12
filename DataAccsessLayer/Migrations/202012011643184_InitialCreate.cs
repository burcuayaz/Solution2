namespace DataAccsessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
            CreateTable(
                "dbo.TBL_KATEGORILER",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KATEGORI_ADI = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TBL_MARKA",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MARKA_ADI = c.String(unicode: false),
                        KATEGORI_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TBL_KATEGORILER", t => t.KATEGORI_ID)
                .Index(t => t.KATEGORI_ID);
            
            CreateTable(
                "dbo.TBL_MODEL",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MODEL_ADI = c.String(unicode: false),
                        KATEGORI_ID = c.Int(nullable: false),
                        MARKA_ID = c.Int(nullable: false),
                        TARIH = c.DateTime(nullable: false),
                        MOTOR_HACMI = c.Int(),
                        VITES_TURU = c.String(unicode: false),
                        RENK = c.String(unicode: false),
                        MOTOR_GUCU = c.Int(),
                        FIYAT = c.Decimal(nullable: false, precision: 28, scale: 2),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TBL_MARKA", t => t.MARKA_ID)
                .ForeignKey("dbo.TBL_KATEGORILER", t => t.KATEGORI_ID)
                .Index(t => t.KATEGORI_ID)
                .Index(t => t.MARKA_ID);
            
            CreateTable(
                "dbo.TBL_SATIS",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KATEGORI_ID = c.Int(nullable: false),
                        MARKA_ID = c.Int(nullable: false),
                        MODEL_ID = c.Int(nullable: false),
                        MUSTERI_ID = c.Int(nullable: false),
                        ADET = c.Int(nullable: false),
                        FIYAT = c.Decimal(nullable: false, precision: 28, scale: 2),
                        TARIH = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TBL_MUSTERILER", t => t.MUSTERI_ID)
                .ForeignKey("dbo.TBL_MODEL", t => t.MODEL_ID)
                .ForeignKey("dbo.TBL_MARKA", t => t.MARKA_ID)
                .ForeignKey("dbo.TBL_KATEGORILER", t => t.KATEGORI_ID)
                .Index(t => t.KATEGORI_ID)
                .Index(t => t.MARKA_ID)
                .Index(t => t.MODEL_ID)
                .Index(t => t.MUSTERI_ID);
            
            CreateTable(
                "dbo.TBL_MUSTERILER",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ADSOYAD = c.String(unicode: false),
                        TELEFON = c.String(unicode: false),
                        ADRES = c.String(unicode: false),
                        MAIL = c.String(unicode: false),
                        KAYIT_TARIHI = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TBL_KULLANICI",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AD = c.String(unicode: false),
                        SOYAD = c.String(unicode: false),
                        MAIL = c.String(unicode: false),
                        TELEFON = c.String(),
                        KULLANICI_ADI = c.String(unicode: false),
                        SIFRE = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TBL_SATIS", "KATEGORI_ID", "dbo.TBL_KATEGORILER");
            DropForeignKey("dbo.TBL_MODEL", "KATEGORI_ID", "dbo.TBL_KATEGORILER");
            DropForeignKey("dbo.TBL_MARKA", "KATEGORI_ID", "dbo.TBL_KATEGORILER");
            DropForeignKey("dbo.TBL_SATIS", "MARKA_ID", "dbo.TBL_MARKA");
            DropForeignKey("dbo.TBL_MODEL", "MARKA_ID", "dbo.TBL_MARKA");
            DropForeignKey("dbo.TBL_SATIS", "MODEL_ID", "dbo.TBL_MODEL");
            DropForeignKey("dbo.TBL_SATIS", "MUSTERI_ID", "dbo.TBL_MUSTERILER");
            DropIndex("dbo.TBL_SATIS", new[] { "MUSTERI_ID" });
            DropIndex("dbo.TBL_SATIS", new[] { "MODEL_ID" });
            DropIndex("dbo.TBL_SATIS", new[] { "MARKA_ID" });
            DropIndex("dbo.TBL_SATIS", new[] { "KATEGORI_ID" });
            DropIndex("dbo.TBL_MODEL", new[] { "MARKA_ID" });
            DropIndex("dbo.TBL_MODEL", new[] { "KATEGORI_ID" });
            DropIndex("dbo.TBL_MARKA", new[] { "KATEGORI_ID" });
            DropTable("dbo.TBL_KULLANICI");
            DropTable("dbo.TBL_MUSTERILER");
            DropTable("dbo.TBL_SATIS");
            DropTable("dbo.TBL_MODEL");
            DropTable("dbo.TBL_MARKA");
            DropTable("dbo.TBL_KATEGORILER");
            DropTable("dbo.sysdiagrams");
        }
    }
}
