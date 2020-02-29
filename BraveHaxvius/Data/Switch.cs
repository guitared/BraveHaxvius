using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class Switch
    {
        public String SwitchId { get; set; }
        public String SwitchType { get; set; }
        public String SwitchBit { get; set; }

        public static readonly Switch Switch_10000000 = new Switch { SwitchId = "10000000", SwitchType = "10", SwitchBit = "0"};
        public static readonly Switch Switch_830202201 = new Switch { SwitchId = "830202201", SwitchType = "800", SwitchBit = "1017"};

		public static readonly List<Switch> Switchs = new List<Switch>
		{
           Switch_10000000,
           Switch_830202201,
		};
    }
}