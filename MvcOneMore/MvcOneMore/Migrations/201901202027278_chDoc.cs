namespace MvcOneMore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chDoc : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Documents", "Ukupno", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Documents", "Ukupno", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
