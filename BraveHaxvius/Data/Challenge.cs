using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class Challenge
    {
        public String Name { get; set; }
        public String MissionId { get; set; }
        public String ChallengeId { get; set; }
        public String Description { get; set; }
        public String DailyQuestName { get; set; }
        public String CountId { get; set; }
        public String ChallengeRequirement { get; set; }
        public String ChallengeReward { get; set; }

        public static readonly Challenge Completethequest_11101010 = new Challenge { Name = "Complete the quest", MissionId = "1110101", ChallengeId = "11101010", Description = "クエストをクリア", DailyQuestName = "土の神殿・入口", CountId = "0", ChallengeRequirement = "68", ChallengeReward = "50:1:20"};
        
        public static readonly Challenge BlueMageFinalearnsthebluemagicmagicmindblast = new Challenge { Name = "Blue Mage Fina learns the blue magic magic mind blast", MissionId = "12211405", ChallengeId = "122114051", Description = "青魔道士フィーナをパーティに編成", DailyQuestName = "秘密の抜け道・イルメアの虚無竜", CountId = "1", ChallengeRequirement = "36:100025705", ChallengeReward = "91:10540500:1"};

		public static readonly List<Challenge> Challenges = new List<Challenge>
		{
           Completethequest_11101010,
           BlueMageFinalearnsthebluemagicmagicmindblast,
		};
    }
}