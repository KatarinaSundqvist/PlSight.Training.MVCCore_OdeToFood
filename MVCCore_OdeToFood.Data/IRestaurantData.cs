using MVCCore_OdeToFood.Core;
using System.Collections.Generic;
using System.Linq;

namespace MVCCore_OdeToFood.Data {
    public interface IRestaurantData {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData {

        List<Restaurant> restaurants;
        public InMemoryRestaurantData() {
            restaurants = new List<Restaurant>() {
                new Restaurant{ Id = 1, Name = "Scott's Pizza", Location = "Maryland", Cuisine = CuisineType.Italian },
                new Restaurant{ Id = 2, Name = "Annapurna", Location = "Castricum", Cuisine = CuisineType.Indian },
                new Restaurant{ Id = 3, Name = "Taco Bell", Location = "California", Cuisine = CuisineType.Mexican }
            };
        }
        public IEnumerable<Restaurant> GetAll() {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}