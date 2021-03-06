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

        public static readonly ImportantItem Crest = new ImportantItem { Name = "Crest", ImportantId = "20", Description = "クレスト", CountId = "2", ItemStack = "99", ItemIdClone = "600000020", SublimationUnitId = ""};
        public static readonly ImportantItem EXPKey = new ImportantItem { Name = "EXP Key", ImportantId = "30", Description = "経験値キー", CountId = "3", ItemStack = "99", ItemIdClone = "600000030", SublimationUnitId = "3600"};
        public static readonly ImportantItem JeweledKey = new ImportantItem { Name = "Jeweled Key", ImportantId = "40", Description = "ジュエルキー", CountId = "4", ItemStack = "99", ItemIdClone = "600000040", SublimationUnitId = "3600"};
        public static readonly ImportantItem RareSummonTicket = new ImportantItem { Name = "Rare Summon Ticket", ImportantId = "50", Description = "レア召喚チケット", CountId = "5", ItemStack = "99", ItemIdClone = "600000050", SublimationUnitId = ""};
        public static readonly ImportantItem ArenaSummonTicket = new ImportantItem { Name = "Arena Summon Ticket", ImportantId = "60", Description = "アリーナ召喚チケット", CountId = "6", ItemStack = "99", ItemIdClone = "600000060", SublimationUnitId = ""};
        public static readonly ImportantItem GuaranteedTicket = new ImportantItem { Name = "4★+ Guaranteed Ticket", ImportantId = "70", Description = "★4以上確定召喚チケット", CountId = "7", ItemStack = "99", ItemIdClone = "600000070", SublimationUnitId = ""};
        public static readonly ImportantItem NRGRestore_100 = new ImportantItem { Name = "NRG Restore 10", ImportantId = "100", Description = "体力回復薬10", CountId = "100", ItemStack = "99", ItemIdClone = "600000100", SublimationUnitId = "10"};
        public static readonly ImportantItem NRGRestore_110 = new ImportantItem { Name = "NRG Restore 30", ImportantId = "110", Description = "体力回復薬50", CountId = "110", ItemStack = "99", ItemIdClone = "600000110", SublimationUnitId = "50"};
        public static readonly ImportantItem NRGRestore_120 = new ImportantItem { Name = "NRG Restore 50", ImportantId = "120", Description = "体力回復薬100", CountId = "120", ItemStack = "99", ItemIdClone = "600000120", SublimationUnitId = "100"};
        public static readonly ImportantItem EXSummonTicket = new ImportantItem { Name = "EX Summon Ticket", ImportantId = "160", Description = "EX召喚チケット", CountId = "160", ItemStack = "99", ItemIdClone = "600000160", SublimationUnitId = ""};
        public static readonly ImportantItem GuaranteedEXTicket_170 = new ImportantItem { Name = "4★+ Guaranteed EX Ticket", ImportantId = "170", Description = "★4以上確定EX召喚チケット", CountId = "170", ItemStack = "99", ItemIdClone = "600000170", SublimationUnitId = ""};
        public static readonly ImportantItem GuaranteedEXTicket_180 = new ImportantItem { Name = "5★ Guaranteed EX Ticket", ImportantId = "180", Description = "★5以上確定EX召喚チケット", CountId = "180", ItemStack = "99", ItemIdClone = "600000180", SublimationUnitId = ""};
        public static readonly ImportantItem SpecialPass = new ImportantItem { Name = "Special Pass", ImportantId = "890", Description = "特別通行許可証", CountId = "999", ItemStack = "99", ItemIdClone = "600000890", SublimationUnitId = ""};
        public static readonly ImportantItem ArenaRestore = new ImportantItem { Name = "Arena Restore", ImportantId = "902", Description = "アリーナオーブ回復薬", CountId = "902", ItemStack = "99", ItemIdClone = "1300000003", SublimationUnitId = "1"};
        public static readonly ImportantItem RaidRestore = new ImportantItem { Name = "Raid Restore", ImportantId = "903", Description = "レイドオーブ回復薬", CountId = "903", ItemStack = "99", ItemIdClone = "1300000004", SublimationUnitId = "1"};
        public static readonly ImportantItem ExpansionVoucher = new ImportantItem { Name = "Expansion Voucher", ImportantId = "904", Description = "拡張クーポン", CountId = "904", ItemStack = "99", ItemIdClone = "1300000006", SublimationUnitId = ""};
        public static readonly ImportantItem AncientCoin = new ImportantItem { Name = "Ancient Coin", ImportantId = "900", Description = "古幣", CountId = "900", ItemStack = "99", ItemIdClone = "1300000001", SublimationUnitId = ""};
        public static readonly ImportantItem AdvanceToken = new ImportantItem { Name = "Advance Token", ImportantId = "901", Description = "ワープトークン", CountId = "901", ItemStack = "99", ItemIdClone = "1300000002", SublimationUnitId = ""};
        public static readonly ImportantItem SummonTicket_210 = new ImportantItem { Name = "30% 4★ Summon Ticket", ImportantId = "210", Description = "★4確率30%召喚チケット", CountId = "210", ItemStack = "99", ItemIdClone = "600000210", SublimationUnitId = ""};
        public static readonly ImportantItem SummonTicket_220 = new ImportantItem { Name = "50% 4★ Summon Ticket", ImportantId = "220", Description = "★4確率50%召喚チケット", CountId = "220", ItemStack = "99", ItemIdClone = "600000220", SublimationUnitId = ""};
        public static readonly ImportantItem SummonTicket_230 = new ImportantItem { Name = "10% 5★ Summon Ticket", ImportantId = "230", Description = "★5確率10%召喚チケット", CountId = "230", ItemStack = "99", ItemIdClone = "600000230", SublimationUnitId = ""};
        public static readonly ImportantItem SummonTicket_240 = new ImportantItem { Name = "30% 5★ Summon Ticket", ImportantId = "240", Description = "★5確率30%召喚チケット", CountId = "240", ItemStack = "99", ItemIdClone = "600000240", SublimationUnitId = ""};
        public static readonly ImportantItem SummonTicket_250 = new ImportantItem { Name = "50% 5★ Summon Ticket", ImportantId = "250", Description = "★5確率50%召喚チケット", CountId = "250", ItemStack = "99", ItemIdClone = "600000250", SublimationUnitId = ""};
        public static readonly ImportantItem SelectSummonTicket_260 = new ImportantItem { Name = "5★ Select Summon Ticket", ImportantId = "260", Description = "★5セレクト召喚チケット", CountId = "260", ItemStack = "99", ItemIdClone = "600000260", SublimationUnitId = ""};
        public static readonly ImportantItem GreenClover = new ImportantItem { Name = "Green Clover", ImportantId = "905", Description = "Green Clover", CountId = "905", ItemStack = "99", ItemIdClone = "1300000007", SublimationUnitId = "20"};
        public static readonly ImportantItem NagasBlood = new ImportantItem { Name = "Naga's Blood", ImportantId = "906", Description = "Naga's Blood", CountId = "906", ItemStack = "99", ItemIdClone = "1300000008", SublimationUnitId = "20"};
        public static readonly ImportantItem NRGLightSphere = new ImportantItem { Name = "NRG Light Sphere", ImportantId = "907", Description = "NRG Light Sphere", CountId = "907", ItemStack = "99", ItemIdClone = "1300000009", SublimationUnitId = "20"};
        public static readonly ImportantItem PremiumSummonTicket = new ImportantItem { Name = "Premium 10+1 Summon Ticket", ImportantId = "908", Description = "Premium 10+1 Summon Ticket", CountId = "908", ItemStack = "99", ItemIdClone = "908", SublimationUnitId = ""};
        public static readonly ImportantItem GuaranteedSummonTicket = new ImportantItem { Name = "5★ Guaranteed 10+1 Summon Ticket", ImportantId = "909", Description = "5★ Guaranteed 10+1 Summon Ticket", CountId = "909", ItemStack = "99", ItemIdClone = "909", SublimationUnitId = ""};
        public static readonly ImportantItem SpecialReturnSummonTicket_910 = new ImportantItem { Name = "Special Return 3★+ Summon Ticket", ImportantId = "910", Description = "Special Return 3★ Summon Ticket", CountId = "910", ItemStack = "99", ItemIdClone = "910", SublimationUnitId = ""};
        public static readonly ImportantItem SpecialReturnSummonTicket_911 = new ImportantItem { Name = "Special Return 4★+ Summon Ticket", ImportantId = "911", Description = "Special Return 4★ Summon Ticket", CountId = "911", ItemStack = "99", ItemIdClone = "911", SublimationUnitId = ""};
        public static readonly ImportantItem EquipmentEnhancementOrbRestore = new ImportantItem { Name = "Equipment Enhancement Orb Restore", ImportantId = "270", Description = "武具強化イベントオーブ回復薬", CountId = "270", ItemStack = "99", ItemIdClone = "600000270", SublimationUnitId = "1"};
        public static readonly ImportantItem YearAnniversarySpecialSummonTicket_280 = new ImportantItem { Name = "2 Year Anniversary Special Summon Ticket", ImportantId = "280", Description = "2周年記念スペシャル召喚チケット", CountId = "280", ItemStack = "99", ItemIdClone = "600000280", SublimationUnitId = ""};
        public static readonly ImportantItem YearAnniversarySpecialSummonTicket_290 = new ImportantItem { Name = "2 Year Anniversary 4★+ Special Summon Ticket", ImportantId = "290", Description = "2周年記念★4以上確定スペシャル召喚チケット", CountId = "290", ItemStack = "99", ItemIdClone = "600000290", SublimationUnitId = ""};
        public static readonly ImportantItem SummonTicket_912 = new ImportantItem { Name = "5+1 Summon Ticket", ImportantId = "912", Description = "5+1 Summon Ticket", CountId = "912", ItemStack = "99", ItemIdClone = "912", SublimationUnitId = ""};
        public static readonly ImportantItem TrustCoin = new ImportantItem { Name = "Trust Coin", ImportantId = "300", Description = "トラストコイン", CountId = "300", ItemStack = "99", ItemIdClone = "600000300", SublimationUnitId = ""};

		public static readonly List<ImportantItem> ImportantItems = new List<ImportantItem>
		{
           Crest,
           EXPKey,
           JeweledKey,
           RareSummonTicket,
           ArenaSummonTicket,
           GuaranteedTicket,
           NRGRestore_100,
           NRGRestore_110,
           NRGRestore_120,
           EXSummonTicket,
           GuaranteedEXTicket_170,
           GuaranteedEXTicket_180,
           SpecialPass,
           ArenaRestore,
           RaidRestore,
           ExpansionVoucher,
           AncientCoin,
           AdvanceToken,
           SummonTicket_210,
           SummonTicket_220,
           SummonTicket_230,
           SummonTicket_240,
           SummonTicket_250,
           SelectSummonTicket_260,
           GreenClover,
           NagasBlood,
           NRGLightSphere,
           PremiumSummonTicket,
           GuaranteedSummonTicket,
           SpecialReturnSummonTicket_910,
           SpecialReturnSummonTicket_911,
           EquipmentEnhancementOrbRestore,
           YearAnniversarySpecialSummonTicket_280,
           YearAnniversarySpecialSummonTicket_290,
           SummonTicket_912,
           TrustCoin,
		};
    }
}