namespace DatabaseCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers values(1,'Mohamed Essam','01555555555','moessam@gmail.com')");
            Sql("INSERT INTO Customers values(2,'Ahmad Youssef','01222222222','ahmadyoussef@gmail.com')");
            Sql("INSERT INTO Customers values(3,'Ahmed Azzoz','01000000000','azzoz@gmail.com')");
            Sql("INSERT INTO Customers values(4,'Ahmed Korany','01111111111','AKG@gmail.com')");
        }
        
        public override void Down()
        {
        }
    }
}
