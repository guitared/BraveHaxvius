using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class ImportantItem
    {
        public String Name { get; set; }
        public String ImportantId { get; set; }
        public String Description { get; set; }
        public String CountId { get; set; }
        public String ItemStack { get; set; }
        public String ItemIdClone { get; set; }
        public String SublimationUnitId { get; set; }

        public static readonly ImportantItem Crest = new ImportantItem { Name = "Crest", ImportantId = "20", Description = "クレスト", CountId = "2", ItemStack = "99", ItemIdClone = "600000020", SublimationUnitId = "" };
        public static readonly ImportantItem TrustCoin = new ImportantItem { Name = "Trust Coin", ImportantId = "300", Description = "トラストコイン", CountId = "300", ItemStack = "99", ItemIdClone = "600000300", SublimationUnitId = "" };

        public static readonly List<ImportantItem> ImportantItems = new List<ImportantItem>
        {
           Crest,
           TrustCoin,
        };
    }
}