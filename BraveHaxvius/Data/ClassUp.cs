using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class ClassUp
    {
        public String UnitId { get; set; }
        public String Items { get; set; }

        public static readonly ClassUp Unit_100000102 = new ClassUp { UnitId = "100000102", Items = "20:290050100:20,20:290010000:8,20:290050200:5,20:290020000:3"};
        public static readonly ClassUp Unit_401009006 = new ClassUp { UnitId = "401009006", Items = "20:310000540:1"};

		public static readonly List<ClassUp> ClassUps = new List<ClassUp>
		{
           Unit_100000102,
           Unit_401009006,
		};
    }
}