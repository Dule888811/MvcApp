namespace MvcOneMore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tasks : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Kolicina = c.Int(nullable: false),
                        Cena = c.Int(nullable: false),
                        RedniBroj = c.Int(nullable: false),
                        Ukupno = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DocumentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Documents", t => t.DocumentID, cascadeDelete: true)
                .Index(t => t.DocumentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "DocumentID", "dbo.Documents");
            DropIndex("dbo.Tasks", new[] { "DocumentID" });
            DropTable("dbo.Tasks");
        }
    }
}
