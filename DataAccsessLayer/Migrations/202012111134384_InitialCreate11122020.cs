namespace DataAccsessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate11122020 : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.TBL_SATIS", "MODEL_ID", "dbo.TBL_MODEL");
            //DropIndex("dbo.TBL_SATIS", new[] { "MODEL_ID" });
        }
        
        public override void Down()
        {
            //CreateIndex("dbo.TBL_SATIS", "MODEL_ID");
            //AddForeignKey("dbo.TBL_SATIS", "MODEL_ID", "dbo.TBL_MODEL", "ID");
        }
    }
}
