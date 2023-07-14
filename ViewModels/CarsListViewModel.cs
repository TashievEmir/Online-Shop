using Asp.NetMvcApp.Models;

namespace Asp.NetMvcApp.ViewModels
{
    public class CarsListViewModel
    {
        public string currentCategory;
        public IEnumerable<Car> allCars {  get; set; }
    }
}
