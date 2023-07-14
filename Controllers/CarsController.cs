using Asp.NetMvcApp.Interfaces;
using Asp.NetMvcApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetMvcApp.Controllers
{
	public class CarsController : Controller
	{
		private readonly IAllCars _allCars;
		private readonly ICarsCategory _allCategories;

		public CarsController(IAllCars allCars, ICarsCategory allCategories)
		{
			this._allCars = allCars;
			this._allCategories = allCategories;
		}

		public ViewResult List()
		{
			CarsListViewModel obj = new CarsListViewModel();
			obj.allCars = _allCars.Cars;
			obj.currentCategory = "Car";
			return View(obj);
		}
	}
}
