namespace DatabaseCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeatsData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Seats VALUES(1,1,1)");
            Sql("INSERT INTO Seats VALUES(2,2,1)");
            Sql("INSERT INTO Seats VALUES(3,3,1)");
            Sql("INSERT INTO Seats VALUES(4,4,1)");
            Sql("INSERT INTO Seats VALUES(5,5,1)");
            Sql("INSERT INTO Seats VALUES(6,6,1)");
            Sql("INSERT INTO Seats VALUES(7,7,1)");
            Sql("INSERT INTO Seats VALUES(8,8,1)");
            Sql("INSERT INTO Seats VALUES(9,9,1)");
            Sql("INSERT INTO Seats VALUES(10,10,1)");
            Sql("INSERT INTO Seats VALUES(11,1,2)");
            Sql("INSERT INTO Seats VALUES(12,2,2)");
            Sql("INSERT INTO Seats VALUES(13,3,2)");
            Sql("INSERT INTO Seats VALUES(14,4,2)");
            Sql("INSERT INTO Seats VALUES(15,5,2)");
            Sql("INSERT INTO Seats VALUES(16,6,2)");
            Sql("INSERT INTO Seats VALUES(17,7,2)");
            Sql("INSERT INTO Seats VALUES(18,8,2)");
            Sql("INSERT INTO Seats VALUES(19,9,2)");
            Sql("INSERT INTO Seats VALUES(20,10,2)");
        }

        public override void Down()
        {
        }
    }
}
