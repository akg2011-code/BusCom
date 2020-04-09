namespace DatabaseCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BusData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Buses VALUES(1,'Bus01')");
            Sql("INSERT INTO Buses VALUES(2,'Bus02')");
            Sql("INSERT INTO Buses VALUES(3,'Bus03')");
            Sql("INSERT INTO Buses VALUES(4,'Bus04')");
            Sql("INSERT INTO Buses VALUES(5,'Bus05')");
        }
        
        public override void Down()
        {
        }
    }
}
