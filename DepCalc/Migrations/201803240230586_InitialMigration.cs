namespace DepCalc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        ItemName = c.String(nullable: false),
                        GenLedger = c.String(nullable: false),
                        QtyServUnit = c.Double(nullable: false),
                        QtyCount = c.Double(nullable: false),
                        PurchUnit = c.String(nullable: false),
                        CountUnit = c.String(nullable: false),
                        SellUnit = c.String(nullable: false),
                        CountFrequency = c.String(nullable: false),
                        StandCost = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ItemId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Items");
        }
    }
}
