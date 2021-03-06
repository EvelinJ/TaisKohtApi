﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Helpers;

namespace Domain
{
    public class Menu : EssentialEntityBase
    {
        public int MenuId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public DateTime? ActiveFrom { get; set; }
        public DateTime? ActiveTo { get; set; }
        [Range(1,365)]
        public int? RepetitionInterval { get; set; }
        //OneToMany
        public List<DishIngredient> DishIngredients { get; set; } = new List<DishIngredient>();
        public List<MenuDish> MenuDishes { get; set; } = new List<MenuDish>();
        //foreign keys
        [Required]
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        [Required]
        public string UserId { get; set; }
        public User User { get; set; }
        public int? PromotionId { get; set; }
        public Promotion Promotion { get; set; }
    }
}
