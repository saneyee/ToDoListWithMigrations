﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace ToDoListWithMigrations.Models
{
	public class Category
	{
		[Key]
		public int CategoryId { get; set; }
		public string Name { get; set; }
		public virtual ICollection<Item> Items { get; set; }
	}
}