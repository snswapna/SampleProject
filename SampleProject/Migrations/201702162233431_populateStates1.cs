namespace SampleProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateStates1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.States", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.States", "ShortName", c => c.String(maxLength: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.States", "ShortName", c => c.String());
            AlterColumn("dbo.States", "Name", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String());
        }
    }
}
