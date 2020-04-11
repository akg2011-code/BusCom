namespace DatabaseCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BranchIdentityModified : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Trips", "SourceId", "dbo.Branches");
            DropForeignKey("dbo.Trips", "DestinationId", "dbo.Branches");
            DropPrimaryKey("dbo.Branches");
            AlterColumn("dbo.Branches", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Branches", "Id");
            AddForeignKey("dbo.Trips", "SourceId", "dbo.Branches", "Id");
            AddForeignKey("dbo.Trips", "DestinationId", "dbo.Branches", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trips", "DestinationId", "dbo.Branches");
            DropForeignKey("dbo.Trips", "SourceId", "dbo.Branches");
            DropPrimaryKey("dbo.Branches");
            AlterColumn("dbo.Branches", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Branches", "Id");
            AddForeignKey("dbo.Trips", "DestinationId", "dbo.Branches", "Id");
            AddForeignKey("dbo.Trips", "SourceId", "dbo.Branches", "Id");
        }
    }
}
