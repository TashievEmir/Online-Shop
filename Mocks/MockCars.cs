using Asp.NetMvcApp.Interfaces;
using Asp.NetMvcApp.Models;

namespace Asp.NetMvcApp.Mocks
{
	public class MockCars : IAllCars
	{
		private readonly ICarsCategory carsCategory = new MockCategory();
		public IEnumerable<Car> Cars 
		{
			get
			{
				return new List<Car>
				{
					new Car
					{
						Name = "Tesla",
						shortDesc = "",
						longDesc = "",
						Img = "/img/tesla.jpg",
						Price = 45000,
						isFavourite = true,
						Available = true,
						Category = carsCategory.AllCategories.First()
					},
					new Car
					{
						Name = "BMW",
						shortDesc = "stylish",
						longDesc = "usefull",
						Img = "/img/bmw.jpg",
						Price = 40000,
						isFavourite = false,
						Available = false,
						Category = carsCategory.AllCategories.Last()
					},
					new Car
					{
						Name = "Mercedes",
						shortDesc = "stylish",
						longDesc = "usefull",
						Img = "/img/mercedes.jpg",
						Price = 55000,
						isFavourite = true,
						Available = true,
						Category = carsCategory.AllCategories.Last()
					},
					new Car
					{
						Name = "Honda",
						shortDesc = "cheap",
						longDesc = "usefull",
						Img = "/img/honda.jpg",
						Price = 20000,
						isFavourite = false,
						Available = true,
						Category = carsCategory.AllCategories.First()
					}
				};
			}
		}
		public IEnumerable<Car> getFavCars { get => throw new NotImplementedException(); }

		public Car getObjectCar(int carId)
		{
			throw new NotImplementedException();
		}
	}
}
