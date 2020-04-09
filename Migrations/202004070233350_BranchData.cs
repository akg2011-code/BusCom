namespace DatabaseCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BranchData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Branches VALUES(1,'Cairo')");
            Sql("INSERT INTO Branches VALUES(2,'Minia')");
            Sql("INSERT INTO Branches VALUES(3,'Alex')");
            Sql("INSERT INTO Branches VALUES(4,'Assiut')");
            Sql("INSERT INTO Branches VALUES(5,'Mansoura')");

        }

        public override void Down()
        {
        }
    }
}
