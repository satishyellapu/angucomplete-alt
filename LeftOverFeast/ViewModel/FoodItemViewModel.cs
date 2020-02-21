using System;
using System.Collections.Generic;
using System.Text;
using LeftOverFeast.Model;

namespace LeftOverFeast.ViewModel
{
    public class FoodItemViewModel
    {
        public List<FoodItem> MeatItems = new List<FoodItem>()
        {


            new FoodItem
            {
                FCategoryid=6,
                Name="Buffalo Wings",
                BestBeforeDays=10,
                DiscardAfterDays=10,
                ItemImage="Buffalo.jfif"
            },
                  new FoodItem
            {
                FCategoryid=7,
                Name="Cheeseburger",
                BestBeforeDays=10,
                DiscardAfterDays=10,
                ItemImage="Cheeseburger.jfif"
            },
                   new FoodItem
            {
                FCategoryid=8,
                Name="Chicken Fried Steak",
                BestBeforeDays=10,
                DiscardAfterDays=10,
                ItemImage="ChickenFried.jfif"
            },
                
               
             
              new FoodItem
            {
                FCategoryid=18,
                Name="Nachos",
                BestBeforeDays=10,
                DiscardAfterDays=10,
                ItemImage="Nachos.jfif"
            },
             new FoodItem
            {
                FCategoryid=1,
                Name="Pot Roast",
                BestBeforeDays=10,
                DiscardAfterDays=10,
                ItemImage="Potroast.jfif"
            }
        };

        public List<FoodItem> Seafooditems = new List<FoodItem>()
        {
            new FoodItem
            {
                FCategoryid=1,
                Name="Fish",
                BestBeforeDays=10,
                DiscardAfterDays=10,
                ItemImage="fish.jfif"
            },
            new FoodItem
            {
                FCategoryid=2,
                Name="Crab",
                BestBeforeDays=10,
                DiscardAfterDays=10,
                ItemImage="crab.jfif"
            },
            new FoodItem
            {
                FCategoryid=3,
                Name="Prawns",
                BestBeforeDays=10,
                DiscardAfterDays=10,
                ItemImage="prawn.jfif"
            },
           
        };

        public List<FoodItem> Pizzaitems = new List<FoodItem>()
        {
            new FoodItem
            {
                FCategoryid=1,
                Name="Cakes",
                BestBeforeDays=10,
                DiscardAfterDays=10,
                ItemImage="Cakes.jfif"
            },

            new FoodItem
            {
                FCategoryid=3,
                Name="Frenchfries",
                BestBeforeDays=10,
                DiscardAfterDays=10,
                ItemImage="Frenchfries.jfif"
            },

            new FoodItem
            {
                FCategoryid=5,
                Name="Lassi",
                BestBeforeDays=10,
                DiscardAfterDays=10,
                ItemImage="Lassi.jfif"
            },

            new FoodItem
            {
                FCategoryid=7,
                Name="Manchurian",
                BestBeforeDays=10,
                DiscardAfterDays=10,
                ItemImage="Manchurian.jfif"
            },
            new FoodItem
            {
                FCategoryid=8,
                Name="VegCurry",
                BestBeforeDays=10,
                DiscardAfterDays=10,
                ItemImage="VegCurry.jfif"
            },
            new FoodItem
            {
                FCategoryid=1,
                Name="Apple Pie",
                BestBeforeDays=10,
                DiscardAfterDays=10,
                ItemImage="Apple.jfif"
            },
            new FoodItem
            {
                FCategoryid=5,
                Name="Blueberry Cobbler",
                BestBeforeDays=10,
                DiscardAfterDays=10,
                ItemImage="Blueberry.jfif"
            },
                new FoodItem
            {
                FCategoryid=9,
                Name="Clam Chowder",
                BestBeforeDays=10,
                DiscardAfterDays=10,
                ItemImage="ClamChowder.jfif"
            },
                     new FoodItem
            {
                FCategoryid=10,
                Name="Cobb Salad",
                BestBeforeDays=10,
                DiscardAfterDays=10,
                ItemImage="Cobbsalad.jfif"
            },  new FoodItem
            {
                FCategoryid=14,
                Name="Green Chile Stew",
                BestBeforeDays=10,
                DiscardAfterDays=10,
                ItemImage="Greenchile.jfif"
            },
                          new FoodItem
            {
                FCategoryid=15,
                Name="Key Lime Pie",
                BestBeforeDays=10,
                DiscardAfterDays=10,
                ItemImage="Keylimepie.jfif"
            },
        };
    }
}
