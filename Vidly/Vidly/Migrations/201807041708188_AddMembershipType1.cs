namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "DiscountRate", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "DiscountRate");
        }
    }
}
