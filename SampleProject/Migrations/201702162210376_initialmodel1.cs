namespace SampleProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmodel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.States", "ShortName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.States", "ShortName");
        }
    }
}
