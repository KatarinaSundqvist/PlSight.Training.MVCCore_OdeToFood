using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MVCCore_OdeToFood.Core;
using MVCCore_OdeToFood.Data;

namespace MVCCore_OdeToFood {
    public class DetailModel : PageModel {
        private readonly IRestaurantData restaurantData;

        public Restaurant Restaurant { get; set; }

        public DetailModel(IRestaurantData restaurantData) {
            this.restaurantData = restaurantData;
        }

        public IActionResult OnGet(int restaurantId) {
            Restaurant = restaurantData.GetById(restaurantId);
            if (Restaurant == null) {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}