using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class Materia
    {
        public String Name { get; set; }
        public String MateriaId { get; set; }
        public String Description { get; set; }
        public String CountId { get; set; }
        public String EquipmentActiveAbility { get; set; }
        public String EquipmentPassiveAbility { get; set; }
        public String ItemStack { get; set; }
        public String ItemBuyPrice { get; set; }
        public String ItemSellPrice { get; set; }
        public String ItemIdClone { get; set; }
        public String BitNumber { get; set; }

        public static readonly Materia Libra = new Materia { Name = "Libra", MateriaId = "504010010", Description = "ライブラ", CountId = "1150010", EquipmentActiveAbility = "10010", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000002", BitNumber = "1"};
        public static readonly Materia WarGoddessInsignia_504232200 = new Materia { Name = "War Goddess' Insignia+", MateriaId = "504232200", Description = "武神の戦印・改", CountId = "2173060", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232200", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "1005"};

		public static readonly List<Materia> Materias = new List<Materia>
		{
           Libra,
         WarGoddessInsignia_504232200,
		};
    }
}