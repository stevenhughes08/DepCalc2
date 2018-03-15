namespace DepCalc.Migrations
{
    using DepCalc.Models;
    using System.Data.Entity.Migrations;


    internal sealed class Configuration : DbMigrationsConfiguration<DepCalcContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DepCalcContext context)
        {
            

            context.Items.AddOrUpdate(p => p.InvItemId,

                    new Item { InvItemId = 1, InvItemName = "Chicken�", GenLedger = " 1231231 ", QtyServUnit = 8, QtyCount = 1, PurchUnit = " HD ", CountUnit = " HD ", SellUnit = " PC ", CountFrequency = " Daily ", StandCost = 2.6049 },
                    new Item { InvItemId = 2, InvItemName = "Chicken - Grilled�", GenLedger = "1231232 ", QtyServUnit = 8, QtyCount = 1, PurchUnit = " HD ", CountUnit = " HD ", SellUnit = " PC ", CountFrequency = " Daily ", StandCost = 3.4787 },
                    new Item { InvItemId = 3, InvItemName = "K11 Crispy11 Seas�", GenLedger = "1231233 ", QtyServUnit = 37.44, QtyCount = 16, PurchUnit = " CS ", CountUnit = " BG ", SellUnit = " OZ ", CountFrequency = " Weekly ", StandCost = 147.6 },
                    new Item { InvItemId = 4, InvItemName = "Hoagie Bun�", GenLedger = " 1231234 ", QtyServUnit = 1, QtyCount = 72, PurchUnit = " CS ", CountUnit = " EA ", SellUnit = " EA ", CountFrequency = " Weekly ", StandCost = 21.33 },
                    new Item { InvItemId = 5, InvItemName = "Sand Wrap�", GenLedger = " 1231235 ", QtyServUnit = 1, QtyCount = 2000, PurchUnit = " CS ", CountUnit = " EA ", SellUnit = " EA ", CountFrequency = " Weekly ", StandCost = 57.39 },
                    new Item { InvItemId = 6, InvItemName = "Foil Wrap�", GenLedger = " 1231236 ", QtyServUnit = 1, QtyCount = 3000, PurchUnit = " CS ", CountUnit = " EA ", SellUnit = " EA ", CountFrequency = " Weekly ", StandCost = 39 },
                    new Item { InvItemId = 7, InvItemName = "Superbox�", GenLedger = " 1231237 ", QtyServUnit = 1, QtyCount = 500, PurchUnit = " CS ", CountUnit = " EA ", SellUnit = " EA ", CountFrequency = " Weekly ", StandCost = 40.633 },
                    new Item { InvItemId = 8, InvItemName = "Apple Turnover�", GenLedger = " 1231238 ", QtyServUnit = 1, QtyCount = 60, PurchUnit = " CS ", CountUnit = " EA ", SellUnit = " EA ", CountFrequency = " Weekly ", StandCost = 14.91 },
                    new Item { InvItemId = 9, InvItemName = "Carton Big Box�", GenLedger = " 1231239 ", QtyServUnit = 1, QtyCount = 200, PurchUnit = " CS ", CountUnit = " EA ", SellUnit = " EA ", CountFrequency = " Weekly ", StandCost = 33.4284 },
                    new Item { InvItemId = 10, InvItemName = "Kids Meal Lid�", GenLedger = " 1231210 ", QtyServUnit = 1, QtyCount = 400, PurchUnit = " CS ", CountUnit = " EA ", SellUnit = " EA ", CountFrequency = " Weekly ", StandCost = 83.86 },
                    new Item { InvItemId = 11, InvItemName = "HOT WINGS�", GenLedger = " 1231211 ", QtyServUnit = 41, QtyCount = 10, PurchUnit = " CS ", CountUnit = " BG ", SellUnit = " EA ", CountFrequency = " Daily ", StandCost = 76.8719 },
                    new Item { InvItemId = 12, InvItemName = "DIPPING WINGS�", GenLedger = " 1231212 ", QtyServUnit = 43, QtyCount = 10, PurchUnit = " CS ", CountUnit = " BG ", SellUnit = " EA ", CountFrequency = " Weekly ", StandCost = 59.6 },
                    new Item { InvItemId = 13, InvItemName = "Kids Applesauce�", GenLedger = " 1231213 ", QtyServUnit = 1, QtyCount = 50, PurchUnit = " CS ", CountUnit = " EA ", SellUnit = " EA ", CountFrequency = " Weekly ", StandCost = 19.29 },
                    new Item { InvItemId = 14, InvItemName = "Boneless Wings�", GenLedger = " 1231214 ", QtyServUnit = 90, QtyCount = 8, PurchUnit = " CS ", CountUnit = " BG ", SellUnit = " EA ", CountFrequency = " Weekly ", StandCost = 73.84 },
                    new Item { InvItemId = 15, InvItemName = "TB-Shrimp�", GenLedger = " 12312315 - TACO OTH", QtyServUnit = 24, QtyCount = 64, PurchUnit = " CS ", CountUnit = " BG ", SellUnit = " EA ", CountFrequency = " Weekly ", StandCost = 193.2 },
                    new Item { InvItemId = 16, InvItemName = "Spicy BBQ Sauce�", GenLedger = " 12312316 ", QtyServUnit = 41.79, QtyCount = 14, PurchUnit = " CS ", CountUnit = " BG ", SellUnit = " OZ ", CountFrequency = " Weekly ", StandCost = 33.65 },
                    new Item { InvItemId = 17, InvItemName = "Canola Oil�", GenLedger = " 12312317 ", QtyServUnit = 16, QtyCount = 1, PurchUnit = " LB�", CountUnit = " LB ", SellUnit = " OZ ", CountFrequency = " Daily ", StandCost = 0.6758 },
                    new Item { InvItemId = 18, InvItemName = "Hawaiian Buns�", GenLedger = " 12312318 ", QtyServUnit = 1, QtyCount = 120, PurchUnit = " CS ", CountUnit = " EA ", SellUnit = " EA ", CountFrequency = " Weekly ", StandCost = 28.4535 },
                    new Item { InvItemId = 19, InvItemName = "Breading Flour�", GenLedger = " 12312319 ", QtyServUnit = 400, QtyCount = 1, PurchUnit = " BG�", CountUnit = " BG ", SellUnit = " OZ ", CountFrequency = " Weekly ", StandCost = 6.7435 },
                    new Item { InvItemId = 20, InvItemName = "Granola Bars�", GenLedger = " 123123 ", QtyServUnit = 1, QtyCount = 435, PurchUnit = " CS ", CountUnit = " EA ", SellUnit = " EA ", CountFrequency = " Weekly ", StandCost = 60.9 }
                );
        }
    }
}