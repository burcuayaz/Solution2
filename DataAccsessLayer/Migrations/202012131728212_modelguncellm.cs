namespace DataAccsessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelguncellm : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TBL_MODEL", "RESIM", c => c.String());
            AddColumn("dbo.TBL_MODEL", "ACIKLAMA", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TBL_MODEL", "ACIKLAMA");
            DropColumn("dbo.TBL_MODEL", "RESIM");
        }
    }
}
