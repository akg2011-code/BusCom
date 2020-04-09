namespace DatabaseCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniqueBusForTrip : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Trips", "IX_UniqueTripForBus");
            DropIndex("dbo.Trips", new[] { "BusId" });
            CreateIndex("dbo.Trips", new[] { "DepartureTime", "BusId" }, unique: true, name: "IX_UniqueTripForBus");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Trips", "IX_UniqueTripForBus");
            CreateIndex("dbo.Trips", "BusId");
            CreateIndex("dbo.Trips", new[] { "Id", "DepartureTime" }, unique: true, name: "IX_UniqueTripForBus");
        }
    }
}
