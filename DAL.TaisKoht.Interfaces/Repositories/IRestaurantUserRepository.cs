﻿using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interfaces.Repositories;
using Domain;

namespace DAL.TaisKoht.Interfaces.Repositories
{
    public interface IRestaurantUserRepository : IRepository<RestaurantUser>
    {
        bool Exists(int id);
        IEnumerable<RestaurantUser> FindAll(params object[] restaurantId);
        int GetUserRestaurantCount(string userId);
        IEnumerable<RestaurantUser> FindAllByRestaurantId(int restaurantId);
        IEnumerable<RestaurantUser> FindAllByUserId(string userId);

    }
}
