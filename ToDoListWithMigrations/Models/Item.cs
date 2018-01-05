﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoListWithMigrations.Models
{
    [Table("Items")]
	public class Item
	{
		[Key]
		public int ItemId { get; set; }
		public string Description { get; set; }
		public int CategoryId { get; set; }
		public virtual Category Category { get; set; }
	}
}