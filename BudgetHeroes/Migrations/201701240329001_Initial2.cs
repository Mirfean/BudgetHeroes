namespace BudgetHeroes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Heroes", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Heroes", "Power", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Heroes", "Power", c => c.String());
            AlterColumn("dbo.Heroes", "Name", c => c.String());
        }
    }
}
