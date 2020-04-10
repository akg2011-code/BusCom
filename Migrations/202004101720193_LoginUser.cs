namespace DatabaseCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LoginUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoginUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        userName = c.String(maxLength: 450),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.userName, unique: true, name: "IX_Unique_Username");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.LoginUsers", "IX_Unique_Username");
            DropTable("dbo.LoginUsers");
        }
    }
}
