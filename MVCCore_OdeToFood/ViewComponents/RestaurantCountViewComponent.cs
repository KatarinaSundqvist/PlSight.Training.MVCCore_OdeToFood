﻿using Microsoft.AspNetCore.Mvc;
using MVCCore_OdeToFood.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore_OdeToFood.ViewComponents {
    public class RestaurantCountViewComponent : ViewComponent {
       
        private readonly IRestaurantData restaurantData;

        public RestaurantCountViewComponent(IRestaurantData restaurantData) {
            this.restaurantData = restaurantData;
        }

        public IViewComponentResult Invoke() {
            var count = restaurantData.GetCountOfRestaurants();
            return View(count);
        }

    }
}
