//MST_IMPORTANT_ITEM_NAME_300^Trust Coin^Trust Coin---VersionControl
using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class Ticket
    {
        public String Name { get; set; }
        public String GachaCost_zJ1A6HXm { get; set; }
        public String ImportantId { get; set; }
        public String GatheringStageId { get; set; }
        public String ItemCount { get; set; }
        public String Rarity { get; set; }
        public String GachaId { get; set; }

        public static readonly Ticket Crest = new Ticket { Name = "Crest"};
        public static readonly Ticket EXPKey = new Ticket { Name = "EXP Key"};
        public static readonly Ticket JeweledKey = new Ticket { Name = "Jeweled Key"};
        public static readonly Ticket RareSummonTicket = new Ticket { Name = "Rare Summon Ticket", GachaCost_zJ1A6HXm = "17", ImportantId = "50", GatheringStageId = "10020", ItemCount = "1", Rarity = "3", GachaId = ""};
        public static readonly Ticket ArenaSummonTicket = new Ticket { Name = "Arena Summon Ticket"};
        public static readonly Ticket GuaranteedTicket = new Ticket { Name = "4★+ Guaranteed Ticket", GachaCost_zJ1A6HXm = "18", ImportantId = "70", GatheringStageId = "10020", ItemCount = "1", Rarity = "4:95000000,5:5000000@4:50000000,5:50000000", GachaId = ""};
        public static readonly Ticket NRGRestore_100 = new Ticket { Name = "NRG Restore 10"};
        public static readonly Ticket NRGRestore_110 = new Ticket { Name = "NRG Restore 30"};
        public static readonly Ticket NRGRestore_120 = new Ticket { Name = "NRG Restore 50"};
        public static readonly Ticket EXSummonTicket = new Ticket { Name = "EX Summon Ticket", GachaCost_zJ1A6HXm = "10", ImportantId = "160", GatheringStageId = "10010", ItemCount = "1", Rarity = "3", GachaId = ""};
        public static readonly Ticket GuaranteedEXTicket_170 = new Ticket { Name = "4★+ Guaranteed EX Ticket", GachaCost_zJ1A6HXm = "11", ImportantId = "170", GatheringStageId = "10010", ItemCount = "1", Rarity = "4", GachaId = ""};
        public static readonly Ticket GuaranteedEXTicket_180 = new Ticket { Name = "5★ Guaranteed EX Ticket", GachaCost_zJ1A6HXm = "12", ImportantId = "180", GatheringStageId = "10010", ItemCount = "1", Rarity = "5", GachaId = ""};
        public static readonly Ticket SpecialPass = new Ticket { Name = "Special Pass"};
        public static readonly Ticket ArenaRestore = new Ticket { Name = "Arena Restore"};
        public static readonly Ticket RaidRestore = new Ticket { Name = "Raid Restore"};
        public static readonly Ticket ExpansionVoucher = new Ticket { Name = "Expansion Voucher"};
        public static readonly Ticket AncientCoin = new Ticket { Name = "Ancient Coin"};
        public static readonly Ticket AdvanceToken = new Ticket { Name = "Advance Token"};
        public static readonly Ticket SummonTicket_210 = new Ticket { Name = "30% 4★ Summon Ticket", GachaCost_zJ1A6HXm = "20", ImportantId = "210", GatheringStageId = "10020", ItemCount = "1", Rarity = "3:67000000,4:30000000,5:3000000@3:69000000,4:30500000,5:500000", GachaId = ""};
        public static readonly Ticket SummonTicket_220 = new Ticket { Name = "50% 4★ Summon Ticket", GachaCost_zJ1A6HXm = "21", ImportantId = "220", GatheringStageId = "10020", ItemCount = "1", Rarity = "3:47000000,4:50000000,5:3000000@3:49000000,4:50500000,5:500000", GachaId = ""};
        public static readonly Ticket SummonTicket_230 = new Ticket { Name = "10% 5★ Summon Ticket", GachaCost_zJ1A6HXm = "22", ImportantId = "230", GatheringStageId = "10020", ItemCount = "1", Rarity = "3:71000000,4:19000000,5:10000000@3:89000000,4:500000,5:10500000", GachaId = ""};
        public static readonly Ticket SummonTicket_240 = new Ticket { Name = "30% 5★ Summon Ticket", GachaCost_zJ1A6HXm = "23", ImportantId = "240", GatheringStageId = "10020", ItemCount = "1", Rarity = "3:51000000,4:19000000,5:30000000@3:69000000,4:500000,5:30500000", GachaId = ""};
        public static readonly Ticket SummonTicket_250 = new Ticket { Name = "50% 5★ Summon Ticket", GachaCost_zJ1A6HXm = "24", ImportantId = "250", GatheringStageId = "10020", ItemCount = "1", Rarity = "3:31000000,4:19000000,5:50000000@3:49000000,4:500000,5:50500000", GachaId = ""};
        public static readonly Ticket SelectSummonTicket_260 = new Ticket { Name = "5★ Select Summon Ticket", GachaCost_zJ1A6HXm = "27", ImportantId = "260", GatheringStageId = "10040", ItemCount = "1", Rarity = "5", GachaId = ""};
        public static readonly Ticket GreenClover = new Ticket { Name = "Green Clover"};
        public static readonly Ticket NagasBlood = new Ticket { Name = "Naga's Blood"};
        public static readonly Ticket NRGLightSphere = new Ticket { Name = "NRG Light Sphere"};
        public static readonly Ticket PremiumSummonTicket = new Ticket { Name = "Premium 10+1 Summon Ticket"};
        public static readonly Ticket GuaranteedSummonTicket = new Ticket { Name = "5★ Guaranteed 10+1 Summon Ticket"};
        public static readonly Ticket SpecialReturnSummonTicket_910 = new Ticket { Name = "Special Return 3★+ Summon Ticket"};
        public static readonly Ticket SpecialReturnSummonTicket_911 = new Ticket { Name = "Special Return 4★+ Summon Ticket"};
        public static readonly Ticket EquipmentEnhancementOrbRestore = new Ticket { Name = "Equipment Enhancement Orb Restore"};
        public static readonly Ticket YearAnniversarySpecialSummonTicket_280 = new Ticket { Name = "2 Year Anniversary Special Summon Ticket", GachaCost_zJ1A6HXm = "25", ImportantId = "280", GatheringStageId = "10030", ItemCount = "1", Rarity = "3", GachaId = ""};
        public static readonly Ticket YearAnniversarySpecialSummonTicket_290 = new Ticket { Name = "2 Year Anniversary 4★+ Special Summon Ticket", GachaCost_zJ1A6HXm = "26", ImportantId = "290", GatheringStageId = "10030", ItemCount = "1", Rarity = "4:95000000,5:5000000@4:50000000,5:50000000", GachaId = ""};
        public static readonly Ticket SummonTicket_912 = new Ticket { Name = "5+1 Summon Ticket"};
        public static readonly Ticket TrustCoin = new Ticket { Name = "Trust Coin"};
/*VersionControldefinitions*/

		public static readonly List<Ticket> Tickets = new List<Ticket>
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
/*VersionControldefinitionsList*/
		};
    }
}