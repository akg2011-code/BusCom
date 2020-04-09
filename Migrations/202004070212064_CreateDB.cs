namespace DatabaseCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        BranchName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trips",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        SourceId = c.Int(nullable: false),
                        DestinationId = c.Int(nullable: false),
                        DepartureTime = c.DateTime(nullable: false),
                        BusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buses", t => t.BusId)
                .ForeignKey("dbo.Branches", t => t.SourceId)
                .ForeignKey("dbo.Branches", t => t.DestinationId)
                .Index(t => new { t.Id, t.DepartureTime }, unique: true, name: "IX_UniqueTripForBus")
                .Index(t => t.SourceId)
                .Index(t => t.DestinationId)
                .Index(t => t.BusId);
            
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        BusTitle = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Seats",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        SeatNumber = c.Int(nullable: false),
                        BusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buses", t => t.BusId)
                .Index(t => new { t.BusId, t.SeatNumber }, unique: true, name: "IX_UniqueSeat");
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        FullName = c.String(nullable: false),
                        MobileNumber = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        SeatId = c.Int(nullable: false),
                        TripId = c.Int(nullable: false),
                        TicketNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .ForeignKey("dbo.Seats", t => t.SeatId)
                .ForeignKey("dbo.Trips", t => t.TripId)
                .Index(t => t.CustomerId)
                .Index(t => new { t.SeatId, t.TripId }, unique: true, name: "IX_UniqueTicket");
            Sql("ALTER TABLE Trips ADD CONSTRAINT CK_Different_Source_And_Destination CHECK (SourceId <> DestinationId)");

        }

        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "TripId", "dbo.Trips");
            DropForeignKey("dbo.Tickets", "SeatId", "dbo.Seats");
            DropForeignKey("dbo.Tickets", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Trips", "DestinationId", "dbo.Branches");
            DropForeignKey("dbo.Trips", "SourceId", "dbo.Branches");
            DropForeignKey("dbo.Trips", "BusId", "dbo.Buses");
            DropForeignKey("dbo.Seats", "BusId", "dbo.Buses");
            DropIndex("dbo.Tickets", "IX_UniqueTicket");
            DropIndex("dbo.Tickets", new[] { "CustomerId" });
            DropIndex("dbo.Seats", "IX_UniqueSeat");
            DropIndex("dbo.Trips", new[] { "BusId" });
            DropIndex("dbo.Trips", new[] { "DestinationId" });
            DropIndex("dbo.Trips", new[] { "SourceId" });
            DropIndex("dbo.Trips", "IX_UniqueTripForBus");
            DropTable("dbo.Tickets");
            DropTable("dbo.Customers");
            DropTable("dbo.Seats");
            DropTable("dbo.Buses");
            DropTable("dbo.Trips");
            DropTable("dbo.Branches");
        }
    }
}
