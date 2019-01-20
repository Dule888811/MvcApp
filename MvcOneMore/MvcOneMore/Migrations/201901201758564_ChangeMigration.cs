namespace MvcOneMore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Documents", "Ukupno", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Documents", "Ukupno");
        }
    }
}
