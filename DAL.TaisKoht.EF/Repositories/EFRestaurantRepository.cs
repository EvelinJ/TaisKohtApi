﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.EF;
using DAL.TaisKoht.Interfaces.Repositories;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace DAL.TaisKoht.EF.Repositories
{
    public class EFRestaurantRepository : EFRepository<Restaurant>, IRestaurantRepository
    {
        public EFRestaurantRepository(DbContext dataContext) : base(dataContext)
        {
        }

        public bool Exists(int id)
        {
            return RepositoryDbSet.Any(e => e.RestaurantId == id);
        }

        public override Restaurant Find(params object[] id)
        {
            return RepositoryDbSet
                //.Include(y => y.Menus)
                //.Include(x => x.Dishes)
                //.Include(z => z.Promotions)
                .SingleOrDefault(x => (int)id[0] == x.RestaurantId);
        }

        public override IEnumerable<Restaurant> All()
        {
            return RepositoryDbSet.AsQueryable()
                //.Include(x => x.Menus)
                //.ThenInclude(y => y.Dishes)
                //.ThenInclude(z => z.Promotions)
                .ToList();
        }
    }
}