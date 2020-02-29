using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class Recipe
    {
        public String Name { get; set; }
        public String RecipeBookId { get; set; }
        public String Description { get; set; }
        public String CountId { get; set; }
        public String Gil { get; set; }

        public static readonly Recipe Potion = new Recipe { Name = "Potion"};
        public static readonly Recipe EdelsEarrings = new Recipe { Name = "Edel's Earrings"};

		public static readonly List<Recipe> Recipes = new List<Recipe>
		{
           Potion,
                  EdelsEarrings,
		};
    }
}