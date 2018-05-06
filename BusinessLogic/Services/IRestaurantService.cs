﻿using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogic.DTO;

namespace BusinessLogic.Services
{
    public interface IRestaurantService
    {
        IEnumerable<RestaurantDTO> GetAllRestaurants();

        RestaurantDTO GetRestaurantById(int id);

        RestaurantDTO AddNewRestaurant(RestaurantDTO dto);

        void UpdateRestaurant(int id, RestaurantDTO dto);

        void DeleteRestaurant(int id);
    }
}
