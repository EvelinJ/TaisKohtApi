﻿using BusinessLogic.DTO;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Factories
{
    public interface IIngredientFactory
    {
        IngredientDTO Create(Ingredient ingredient);
        Ingredient Create(IngredientDTO ingredientDTO);
    }

    public class IngredientFactory : IIngredientFactory
    {
        public IngredientDTO Create(Ingredient ingredient)
        {
            return IngredientDTO.CreateFromDomain(ingredient);
        }

        public Ingredient Create(IngredientDTO ingredientDTO)
        {
            return new Ingredient
            {
                IngredientId = ingredientDTO.IngredientId,
                UserId = ingredientDTO.UserId,
                Name = ingredientDTO.Name,
                Description = ingredientDTO.Description,
                AmountUnit = ingredientDTO.AmountUnit,
                AddTime = ingredientDTO.AddTime,
                UpdateTime = ingredientDTO.UpdateTime,
                Active = ingredientDTO.Active
            };
        }
    }
}