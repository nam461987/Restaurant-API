﻿using Restaurant.Entities.Models;
using Restaurant.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Repository
{
    public class StateRepository : BaseRepository<State>, IStateRepository
    {
        public StateRepository(restaurantContext context)
            : base(context)
        {
        }
    }
}
