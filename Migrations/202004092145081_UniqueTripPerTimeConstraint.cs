namespace DatabaseCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniqueTripPerTimeConstraint : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Trips", new[] { "SourceId" });
            DropIndex("dbo.Trips", new[] { "DestinationId" });
            DropIndex("dbo.Trips", "IX_UniqueTripForBus");
            CreateIndex("dbo.Trips", new[] { "SourceId", "DestinationId", "DepartureTime" }, unique: true, name: "IX_UniqueTripPerTime");
            CreateIndex("dbo.Trips", "BusId", unique: true, name: "IX_UniqueBus");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Trips", "IX_UniqueBus");
            DropIndex("dbo.Trips", "IX_UniqueTripPerTime");
            CreateIndex("dbo.Trips", new[] { "DepartureTime", "BusId" }, unique: true, name: "IX_UniqueTripForBus");
            CreateIndex("dbo.Trips", "DestinationId");
            CreateIndex("dbo.Trips", "SourceId");
        }
    }
}
