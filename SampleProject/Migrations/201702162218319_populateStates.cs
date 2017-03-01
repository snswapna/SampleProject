namespace SampleProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateStates : DbMigration
    {
        public override void Up()
        {

            Sql("Insert into States(Name, ShortName, Tax) Values('Arizona','AZ',5)");
            Sql("Insert into States(Name, ShortName, Tax) Values('California','CA',5)");
            Sql("Insert into States(Name, ShortName, Tax) Values('West Virginia','WV',5)");
            Sql("Insert into States(Name, ShortName, Tax) Values('Florida','FL',0)");
            Sql("Insert into States(Name, ShortName, Tax) Values('Virginia','VA',5)");
            Sql("Insert into States(Name, ShortName, Tax) Values('Texas','TX',0)");
            Sql("Insert into States(Name, ShortName, Tax) Values('North Carolina','NC',5)");

        }
        
        public override void Down()
        {
        }
    }
}
