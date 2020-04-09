namespace DatabaseCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TripsData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Trips VALUES(1,1,2,'2020-04-10 10:00:00',1)");
            Sql("INSERT INTO Trips VALUES(2,1,2,'2020-04-10 22:00:00',1)");
            Sql("INSERT INTO Trips VALUES(3,1,3,'2020-04-11 22:00:00',2)");

        }

        public override void Down()
        {

        }
    }
}
