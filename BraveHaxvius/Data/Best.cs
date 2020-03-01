using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class Best
    {
        public String Name { get; set; }
        public String BeastId { get; set; }
        public String Description { get; set; }
        public String CountId { get; set; }

        public static readonly Best Siren = new Best { Name = "Siren", BeastId = "1", Description = "セイレーン", CountId = "1"};
        public static readonly Best Ifrit = new Best { Name = "Ifrit", BeastId = "2", Description = "イフリート", CountId = "2"};
        public static readonly Best Shiva = new Best { Name = "Shiva", BeastId = "3", Description = "シヴァ", CountId = "3"};
        public static readonly Best Carbuncle = new Best { Name = "Carbuncle", BeastId = "4", Description = "カーバンクル", CountId = "7"};
        public static readonly Best Diabolos = new Best { Name = "Diabolos", BeastId = "5", Description = "ディアボロス", CountId = "6"};
        public static readonly Best Golem = new Best { Name = "Golem", BeastId = "6", Description = "ゴーレム", CountId = "4"};
        public static readonly Best Ramuh = new Best { Name = "Ramuh", BeastId = "7", Description = "ラムウ", CountId = "5"};
        public static readonly Best Titan = new Best { Name = "Titan", BeastId = "8", Description = "タイタン", CountId = "9"};
        public static readonly Best TetraSylphid = new Best { Name = "Tetra Sylphid", BeastId = "9", Description = "テトラシルフィード", CountId = "11"};
        public static readonly Best Odin = new Best { Name = "Odin", BeastId = "10", Description = "オーディン", CountId = "8"};
        public static readonly Best Lakshmi = new Best { Name = "Lakshmi", BeastId = "11", Description = "ラクシュミ", CountId = "10"};
        public static readonly Best Leviathan = new Best { Name = "Leviathan", BeastId = "12", Description = "繝ｪ繝ｴ繧｡繧､繧｢繧ｵ繝ｳ", CountId = "14"};
        public static readonly Best Phoenix = new Best { Name = "Phoenix", BeastId = "14", Description = "フェニックス", CountId = "15"};
        public static readonly Best Bahamut = new Best { Name = "Bahamut", BeastId = "15", Description = "繝舌ワ繝繝ｼ繝", CountId = "12"};
        public static readonly Best Fenrir = new Best { Name = "Fenrir", BeastId = "16", Description = "繝輔ぉ繝ｳ繝ｪ繝ｫ", CountId = "13"};
        public static readonly Best Alexander = new Best { Name = "Alexander", BeastId = "13", Description = "アレキサンダー", CountId = "16"};
        public static readonly Best Anima = new Best { Name = "Anima", BeastId = "17", Description = "アニマ", CountId = "17"};
        public static readonly Best Asura = new Best { Name = "Asura", BeastId = "18", Description = "阿修羅", CountId = "18"};
        public static readonly Best Kokuryu = new Best { Name = "Kokuryu", BeastId = "19", Description = "黒龍", CountId = "19"};

		public static readonly List<Best> Bests = new List<Best>
		{
           Siren,
           Ifrit,
           Shiva,
           Carbuncle,
           Diabolos,
           Golem,
           Ramuh,
           Titan,
           TetraSylphid,
           Odin,
           Lakshmi,
           Leviathan,
           Phoenix,
           Bahamut,
           Fenrir,
           Alexander,
           Anima,
           Asura,
           Kokuryu,
		};
    }
}