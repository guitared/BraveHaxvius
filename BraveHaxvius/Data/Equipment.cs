using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class Equipment
    {
        public String Name { get; set; }
        public String EquipId { get; set; }
        public String Description { get; set; }
        public String EquipmentRarity { get; set; }
        public String CountId { get; set; }
        public String EquipmentSlotId { get; set; }
        public String EquipmentTypeId { get; set; }
        public String EquipmentRequirement { get; set; }
        public String MonsterHp { get; set; }
        public String MonsterMp { get; set; }
        public String MonsterAtk { get; set; }
        public String MonsterDef { get; set; }
        public String MonsterMag { get; set; }
        public String MonsterMnd { get; set; }
        public String EquipmentElementInflict { get; set; }
        public String EquipmentStatusInflict { get; set; }
        public String ElementResists { get; set; }
        public String StatusResists { get; set; }
        public String PhysicalResist { get; set; }
        public String MagicalResist { get; set; }
        public String EquipmentActiveAbility { get; set; }
        public String EquipmentPassiveAbility { get; set; }
        public String ItemStack { get; set; }
        public String ItemBuyPrice { get; set; }
        public String ItemSellPrice { get; set; }
        public String ItemIdClone { get; set; }
        public String BitNumber { get; set; }

        public static readonly Equipment BronzeKnife = new Equipment { Name = "Bronze Knife", EquipId = "301000200", Description = "ブロンズナイフ", EquipmentRarity = "1", CountId = "1", EquipmentSlotId = "1", EquipmentTypeId = "1", EquipmentRequirement = "", MonsterHp = "0", MonsterMp = "0", MonsterAtk = "10", MonsterDef = "0", MonsterMag = "0", MonsterMnd = "0", EquipmentElementInflict = "0,0,0,0,0,0,0,0", EquipmentStatusInflict = "0,0,0,0,0,0,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", EquipmentActiveAbility = "", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "301000200", BitNumber = "1"};
        
        public static readonly Equipment BelovedEdel = new Equipment { Name = "Beloved Edel", EquipId = "313006100", Description = "ディアエーデル", EquipmentRarity = "8", CountId = "1367", EquipmentSlotId = "1", EquipmentTypeId = "14", EquipmentRequirement = "", MonsterHp = "0", MonsterMp = "0", MonsterAtk = "152", MonsterDef = "0", MonsterMag = "0", MonsterMnd = "0", EquipmentElementInflict = "0,0,0,0,0,1,0,0", EquipmentStatusInflict = "0,0,0,0,0,0,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", EquipmentActiveAbility = "", EquipmentPassiveAbility = "231974", ItemStack = "99", ItemBuyPrice = "120000", ItemSellPrice = "12000", ItemIdClone = "313006100", BitNumber = "1404"};

		public static readonly List<Equipment> Equipments = new List<Equipment>
		{
           BronzeKnife,
           BelovedEdel,
		};
    }
}