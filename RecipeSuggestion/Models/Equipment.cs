﻿namespace RecipeSuggestion.Models
{
	public class Equipment
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string LocalizedName { get; set; }

		public string Image { get; set; }

		public Temperature Temperature { get; set; }
	}
}
