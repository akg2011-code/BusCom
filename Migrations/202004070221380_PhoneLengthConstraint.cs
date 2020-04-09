namespace DatabaseCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhoneLengthConstraint : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "MobileNumber", c => c.String(maxLength: 11));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "MobileNumber", c => c.String());
        }
    }
}
