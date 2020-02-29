using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class Sublimation
    {
        public String SublimationId { get; set; }
        public String UnitId { get; set; }
        public String Items { get; set; }

        public static readonly Sublimation Sublimation_100050001 = new Sublimation { SublimationId = "100050001", UnitId = "208000205", Items = "20:270004100:20,20:270004200:15,20:270004300:10,20:270004400:4,20:270004500:2"};
		public static readonly Sublimation Sublimation_912070002 = new Sublimation { SublimationId = "912070002", UnitId = "401006705", Items = "20:270004100:15,20:270004200:12,20:270004300:5,20:270004400:1,20:270004500:1"};

		public static readonly List<Sublimation> Sublimations = new List<Sublimation>
		{
           Sublimation_100050001,
           Sublimation_912070002,
		};
    }
}