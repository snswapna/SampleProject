namespace SampleProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateproducts : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Products ( Name, Price, Discount) Values( 'Jumper Roo', 90, 5)");
            Sql("INSERT INTO Products ( Name, Price, Discount) Values( 'Jungle Gym', 50, 0)");
            Sql("INSERT INTO Products ( Name, Price, Discount) Values( 'Baby Walker', 49, 0)");
            Sql("INSERT INTO Products ( Name, Price, Discount) Values( 'High Chair', 150, 0)");
            Sql("INSERT INTO Products ( Name, Price, Discount) Values( 'Car Seat', 100, 5)");
            Sql("INSERT INTO Products ( Name, Price, Discount) Values( 'Stroller', 150, 0)");
            Sql("INSERT INTO Products ( Name, Price, Discount) Values( 'Infant Swing', 120, 5)");
        }
        
        public override void Down()
        {
        }
    }
}
