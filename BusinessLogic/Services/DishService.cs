﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLogic.DTO;
using BusinessLogic.Factories;
using DAL.TaisKoht.Interfaces;
using Domain;

namespace BusinessLogic.Services
{
    public class DishService : IDishService
    {
        private readonly ITaisKohtUnitOfWork _uow;
        private readonly IDishFactory _dishFactory;

        public DishService(ITaisKohtUnitOfWork uow, IDishFactory dishFactory)
        {
            _uow = uow;
            _dishFactory = dishFactory;
        }

        public DishDTO AddNewDish(DishDTO dishDTO)
        {
            var newDish = _dishFactory.Create(dishDTO);
            _uow.Dishes.Add(newDish);
            _uow.SaveChanges();
            return _dishFactory.Create(newDish);
        }

        public IEnumerable<DishDTO> GetAllDishes()
        {
            return _uow.Dishes.All()
                .Select(dish => _dishFactory.Create(dish));
        }

        public DishDTO GetDishById(int id)
        {
            var dish = _uow.Dishes.Find(id);
            if (dish == null) return null;

            return _dishFactory.Create(dish);
        }

        public void UpdateDish(int id, DishDTO updatedDishDTO)
        {
            Dish dish = _uow.Dishes.Find(id);
            dish.Title = updatedDishDTO.Title;
            dish.Description = updatedDishDTO.Description;
            dish.AvailableFrom = updatedDishDTO.AvailableFrom;
            dish.AvailableTo = updatedDishDTO.AvailableTo;
            dish.ServeTime = updatedDishDTO.ServeTime;
            dish.Vegan = updatedDishDTO.Vegan;
            dish.Lactose = updatedDishDTO.Lactose;
            dish.Gluten = updatedDishDTO.Gluten;
            dish.Kcal = updatedDishDTO.Kcal;
            dish.WeightG = updatedDishDTO.WeightG;
            dish.Price = updatedDishDTO.Price;
            dish.DailyPrice = updatedDishDTO.DailyPrice;
            dish.Daily = updatedDishDTO.Daily;
            _uow.Dishes.Update(dish);
            _uow.SaveChanges();
        }

        public void DeleteDish(int id)
        {
            Dish dish = _uow.Dishes.Find(id);
            _uow.Dishes.Remove(dish);
            _uow.SaveChanges();
        }
    }
}