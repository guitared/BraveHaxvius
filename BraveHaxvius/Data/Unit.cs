using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class Unit
    {
        public String Name { get; set; }
        public String UniqueUnitId { get; set; }
        public String Level { get; set; }
        public String Tmr { get; set; }
        public String Equip { get; set; }
        public String UnitId { get; set; }
        public String Description { get; set; }
        public String Rarity { get; set; }
        public String TribeId { get; set; }
        public String GenderId { get; set; }
        public String BaseUnitId { get; set; }
        public String GameId { get; set; }
        public String CountId { get; set; }
        public String UnitMaxLevel { get; set; }
        public String EquipIds { get; set; }
        public String IsCombatUnit { get; set; }
        public String IsPotUnit { get; set; }
        public String IsSummonable { get; set; }
        public String MateriaSlots { get; set; }
        public String UnitHp { get; set; }
        public String UnitMp { get; set; }
        public String UnitAtk { get; set; }
        public String UnitDef { get; set; }
        public String UnitMag { get; set; }
        public String UnitSpr { get; set; }
        public String ElementResists { get; set; }
        public String StatusResists { get; set; }
        public String PhysicalResist { get; set; }
        public String MagicalResist { get; set; }
        public String MagicAffinity { get; set; }
        public String BattleUnitId { get; set; }
        public String IsMoogle { get; set; }
        public String UnitTmrId { get; set; }
        public String BitNumber { get; set; }
        public String AttackFrames { get; set; }
        public String EffectFrames { get; set; }
        public String JobId { get; set; }
        public String UnitXpGain { get; set; }
        public String UnitGilSell { get; set; }
        public String UnitLbGain { get; set; }

        public static readonly Unit Rain_100000102 = new Unit { Name = "Rain", UnitId = "100000102", Description = "レイン", Rarity = "2", TribeId = "5", GenderId = "1", BaseUnitId = "100000102", GameId = "11001", CountId = "1", UnitMaxLevel = "30", EquipIds = "1,2,3,9,15,30,31,40,41,50,51,52,60", IsCombatUnit = "1", IsPotUnit = "0", IsSummonable = "0", MateriaSlots = "1", UnitHp = "378,1144,120,60", UnitMp = "15,45,20,10", UnitAtk = "14,41,8,4", UnitDef = "13,40,8,4", UnitMag = "13,39,8,4", UnitSpr = "12,37,8,4", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", MagicAffinity = "1,2,0,0", BattleUnitId = "100000102", IsMoogle = "0", UnitTmrId = "", BitNumber = "1", AttackFrames = "15:60:3:2-36:40:3:2", EffectFrames = "13:1000320:1&34:1000320:1", JobId = "1", UnitXpGain = "0", UnitGilSell = "0", UnitLbGain = "0"};
        public static readonly Unit Winkel_100023905 = new Unit { Name = "Winkel", UnitId = "100023905", Description = "ヴィンケル", Rarity = "5", TribeId = "5", GenderId = "1", BaseUnitId = "100023903", GameId = "11001", CountId = "1627", UnitMaxLevel = "80", EquipIds = "2,14,16,30,40,41,50,51,60", IsCombatUnit = "1", IsPotUnit = "0", IsSummonable = "0", MateriaSlots = "4", UnitHp = "928,2811,300,150", UnitMp = "40,120,50,25", UnitAtk = "40,120,20,10", UnitDef = "38,115,20,10", UnitMag = "26,80,20,10", UnitSpr = "31,95,20,10", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", MagicAffinity = "0,0,0,0", BattleUnitId = "100023905", IsMoogle = "0", UnitTmrId = "21:409032900:1:1000:1:10:50", BitNumber = "1663", AttackFrames = "12:50:3:2-66:50:3:2", EffectFrames = "10:1000290:1&64:1000770:1&64:7000860:1", JobId = "7", UnitXpGain = "3000", UnitGilSell = "2500", UnitLbGain = "0"};

		public static readonly List<Unit> Units = new List<Unit>
		{
           Rain_100000102,
                     Winkel_100023905,
		};
    }
}