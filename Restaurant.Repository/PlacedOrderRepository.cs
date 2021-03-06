﻿using Restaurant.Entities.Models;
using Restaurant.Repository.Interfaces.Orders;

namespace Restaurant.Repository
{
    public class PlacedOrderRepository : BaseRepository<PlacedOrder>, IPlacedOrderRepository
    {
        public PlacedOrderRepository(restaurantContext context)
            : base(context)
        {
        }
    }
}
