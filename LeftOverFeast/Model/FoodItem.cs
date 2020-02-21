using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace LeftOverFeast.Model
{
    public class FoodItem
    {
        public long FCategoryid { get; set; }
        public string Name { get; set; }
        public int BestBeforeDays { get; set; }
        public int DiscardAfterDays { get; set; }
        public string ItemImage { get; set; }

    }


    public class FoodStore
    {
        [PrimaryKey, AutoIncrement]
        public long FSId { get; set; }
        public long FCategoryid { get; set; }
        public string FCategoryName { get; set; }
        public string FCategoryDesc { get; set; }
        public string Qty { get; set; }
        public string Units { get; set; }
        public string DateStored { get; set; }
        public string ConsumeByDate { get; set; }
        public string DiscardAfterDate { get; set; }
        public string ItemImage { get; set; }

        public string Active { get; set; }
        public string IsConsumed { get; set; }
        public string IsDiscarded { get; set; }

        public string Mode { get; set; }
    }
}


