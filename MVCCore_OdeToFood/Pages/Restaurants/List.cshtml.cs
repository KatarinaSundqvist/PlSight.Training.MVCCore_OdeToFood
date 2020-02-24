using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MVCCore_OdeToFood.Core;
using MVCCore_OdeToFood.Data;
using System.Collections.Generic;

namespace MVCCore_OdeToFood.Pages.Restaurants {
    public class ListModel : PageModel {

        private readonly IConfiguration config;
        private readonly IRestaurantData restaurantData;
        private readonly ILogger<ListModel> logger;

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public string Message { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public ListModel(IConfiguration config, IRestaurantData restaurantData, ILogger<ListModel> logger) {
            this.config = config;
            this.restaurantData = restaurantData;
            this.logger = logger;
        }
        public void OnGet() {
            logger.LogError("Executing ListModel");
            Message = config["Message"];
            Restaurants = restaurantData.GetRestaurantsByName(SearchTerm);
        }
    }
}