using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class Item
    {
        public String Name { get; set; }
        public String ItemId { get; set; }
        public String Description { get; set; }
        public String EquipmentRarity { get; set; }
        public String CountId { get; set; }
        public String IsPotUnit { get; set; }
        public String KeyName { get; set; }
        public String Ha9G5sCS { get; set; }
        public String ItemStack { get; set; }
        public String ItemBuyPrice { get; set; }
        public String ItemSellPrice { get; set; }
        public String ItemIdClone { get; set; }
        public String BitNumber { get; set; }

        public static readonly Item Potion = new Item { Name = "Potion", ItemId = "101000100", Description = "ポーション", EquipmentRarity = "1", CountId = "1", IsPotUnit = "1", KeyName = "6", Ha9G5sCS = "300210,1", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "101000100", BitNumber = "1"};
        public static readonly Item SpringBlossomTicket = new Item { Name = "Spring Blossom Ticket", ItemId = "1209001161", Description = "Spring Blossom Ticket", EquipmentRarity = "8", CountId = "9454", IsPotUnit = "0", KeyName = "0", Ha9G5sCS = "", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001161", BitNumber = "9454"};

		public static readonly List<Item> Items = new List<Item>
		{
           Potion,
        SpringBlossomTicket,
		};
    }
}