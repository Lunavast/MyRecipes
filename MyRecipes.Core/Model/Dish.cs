﻿using System.Collections.Generic;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;


namespace MyRecipes.Core.Model
{
    [Table("Dish")]
    public  class Dish : ITitleDomainObject
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Title { get; set; }

        [ForeignKey(typeof(Category))]
        public int CategoryId { get; set; }

        [ManyToOne]
        public Category Category { get; set; }

        public string CookingProcess { get; set; }

		public bool IsFavorite { get; set; }

        [ManyToMany(typeof(DishProduct))]
        public List<Product> Products { get; set; }
    }
}
