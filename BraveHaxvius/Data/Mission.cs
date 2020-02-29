using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class Mission
    {
        public String Name { get; set; }
        public String MissionId { get; set; }
        public String Description { get; set; }
        public String EquipmentRarity { get; set; }
        public String CountId { get; set; }
        public String ClassUpItems { get; set; }
        public String MapId { get; set; }
        public String RegionId { get; set; }
        public String SubRegionId { get; set; }
        public String DungeonId { get; set; }
        public String Energy { get; set; }
        public String BattleType { get; set; }
        public String MissionType { get; set; }
        public String StdEsperRaidGath { get; set; }
        public String BattleWaves { get; set; }
        public String Experience { get; set; }
        public String Gil { get; set; }
        public String UnitRestricted { get; set; }
        public String EscapeContinueQQ { get; set; }
        public String SnowmanQQ { get; set; }
        public String PumpkinKingQQ { get; set; }
        public String NotEggSeekerQQ { get; set; }
        public String RequiredSwitchId { get; set; }
        public String QuestSwitchIdQQ { get; set; }
        public String GrantedSwitchId { get; set; }
        public String EventDungeonSwitchIdQQ { get; set; }
        public String DungeonSwitchIdQQ { get; set; }
        public String BattleMusicQQ { get; set; }
        public String IconQQ { get; set; }
        public String DungeonCompleteReward { get; set; }
        public String EventQQ { get; set; }
        public String Raid { get; set; }
        public String GatheringStageId { get; set; }

        public static readonly Mission AirshipDeck = new Mission { Name = "Airship - Deck", MissionId = "1110100", Description = "飛空艇・甲板", EquipmentRarity = "1", CountId = "1", ClassUpItems = "", MapId = "1", RegionId = "11", SubRegionId = "111", DungeonId = "11101", Energy = "0", BattleType = "0", MissionType = "1", StdEsperRaidGath = "0", BattleWaves = "2", Experience = "0", Gil = "10", UnitRestricted = "0", EscapeContinueQQ = "10002200:1:0:1:1:1:0", SnowmanQQ = "10005005", PumpkinKingQQ = "1", NotEggSeekerQQ = "1", RequiredSwitchId = "", QuestSwitchIdQQ = "", GrantedSwitchId = "10001100", EventDungeonSwitchIdQQ = "", DungeonSwitchIdQQ = "0", BattleMusicQQ = "0", IconQQ = "100021", DungeonCompleteReward = "", EventQQ = "1", Raid = "0", GatheringStageId = "0"};
        public static readonly Mission CaveofCrystalsSupport_8881703 = new Mission { Name = "Cave of Crystals (Support) 3", MissionId = "8881703", Description = "晶石の洞窟【支援】3", EquipmentRarity = "90", CountId = "4", ClassUpItems = "", MapId = "2", RegionId = "21", SubRegionId = "888", DungeonId = "88817", Energy = "20", BattleType = "0", MissionType = "1", StdEsperRaidGath = "0", BattleWaves = "5", Experience = "740", Gil = "201", UnitRestricted = "0", EscapeContinueQQ = "1:1:1:1:1:1:0", SnowmanQQ = "1", PumpkinKingQQ = "1", NotEggSeekerQQ = "1", RequiredSwitchId = "0", QuestSwitchIdQQ = "", GrantedSwitchId = "18488260", EventDungeonSwitchIdQQ = "", DungeonSwitchIdQQ = "400206", BattleMusicQQ = "400005", IconQQ = "0", DungeonCompleteReward = "", EventQQ = "1", Raid = "0", GatheringStageId = "88817"};

		public static readonly List<Mission> Missions = new List<Mission>
		{
           AirshipDeck,
           CaveofCrystalsSupport_8881703,
		};
    }
}