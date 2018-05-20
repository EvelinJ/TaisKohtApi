﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Domain;

namespace BusinessLogic.DTO
{
    public class PromotionDTO
    {
        public int PromotionId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
        [MaxLength(50)]
        public string Type { get; set; }
        public DateTime ValidTo { get; set; }
        //OneToMany
        public List<MenuDTO> Menus { get; set; } = new List<MenuDTO>();
        public List<DishDTO> Dishes { get; set; } = new List<DishDTO>();
        public List<RestaurantDTO> Restaurants { get; set; } = new List<RestaurantDTO>();

        public static PromotionDTO CreateFromDomain(Promotion promotion)
        {
            if(promotion == null || !promotion.Active) { return null; }
            return new PromotionDTO()
            {
                PromotionId = promotion.PromotionId,
                Name = promotion.Name,
                Description = promotion.Description,
                Type = promotion.Type,
                ValidTo = promotion.ValidTo
            };
        }

        public static PromotionDTO CreateFromDomainWithAssociatedTables(Promotion p)
        {
            var promotion = CreateFromDomain(p);
            if (promotion == null) { return null; }

            promotion.Menus = p.Menus
                .Select(MenuDTO.CreateFromDomain).ToList();
            promotion.Dishes = p.Dishes
                .Select(DishDTO.CreateFromDomain).ToList();
            promotion.Restaurants = p.Restaurants
                .Select(RestaurantDTO.CreateFromDomain).ToList();
            return promotion;
        }

    }
}
