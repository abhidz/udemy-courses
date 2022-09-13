namespace EFCodeFirstApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTempTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Temps",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Categories", "Temp_ID", c => c.Int());
            CreateIndex("dbo.Categories", "Temp_ID");
            AddForeignKey("dbo.Categories", "Temp_ID", "dbo.Temps", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "Temp_ID", "dbo.Temps");
            DropIndex("dbo.Categories", new[] { "Temp_ID" });
            DropColumn("dbo.Categories", "Temp_ID");
            DropTable("dbo.Temps");
        }
    }
}
