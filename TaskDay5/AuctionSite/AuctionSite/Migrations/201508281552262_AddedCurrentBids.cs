namespace AuctionSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCurrentBids : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AuctionItems", "MaximumBids", c => c.Int(nullable: false));
            AddColumn("dbo.AuctionItems", "CurrentBids", c => c.Int(nullable: false));
            DropColumn("dbo.AuctionItems", "NumberOfBids");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AuctionItems", "NumberOfBids", c => c.Int(nullable: false));
            DropColumn("dbo.AuctionItems", "CurrentBids");
            DropColumn("dbo.AuctionItems", "MaximumBids");
        }
    }
}
