namespace DatabaseCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isAdmin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LoginUsers", "isAdmin", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.LoginUsers", "isAdmin");
        }
    }
}
