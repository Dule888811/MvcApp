namespace MvcOneMore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class H : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Documents", "Ukupno", c => c.Int());
            AlterColumn("dbo.Tasks", "Ukupno", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tasks", "Ukupno", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Documents", "Ukupno", c => c.Decimal(precision: 18, scale: 2));
        }
    }
}
