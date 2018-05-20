﻿using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogic.DTO;
using Domain;

namespace BusinessLogic.Factories
{
    public interface IDishFactory
    {
        DishDTO Create(Dish dish);
        DishDTO CreateComplex(Dish dish);
        Dish Create(DishDTO dishDTO);
    }

    public class DishFactory : IDishFactory
    {
        public DishDTO Create(Dish dish)
        {
            return DishDTO.CreateFromDomain(dish);
        }

        public DishDTO CreateComplex(Dish dish)
        {
            return DishDTO.CreateFromDomainWithAssociatedTables(dish);
        }

        public Dish Create(DishDTO dishDTO)
        {
            return new Dish
            {
                DishId = dishDTO.DishId,
                RestaurantId = dishDTO.RestaurantId,
                UserId = dishDTO.UserId,
                PromotionId = dishDTO.PromotionId,
                Title = dishDTO.Title,
                Description = dishDTO.Description,
                AvailableFrom = dishDTO.AvailableFrom,
                AvailableTo = dishDTO.AvailableTo,
                ServeTime = dishDTO.ServeTime,
                Vegan = dishDTO.Vegan,
                LactoseFree = dishDTO.LactoseFree,
                GlutenFree = dishDTO.GlutenFree,
                Kcal = dishDTO.Kcal,
                WeightG = dishDTO.WeightG,
                Price = dishDTO.Price,
                DailyPrice = dishDTO.DailyPrice,
                Daily = dishDTO.Daily
            };
        }
    }
}
