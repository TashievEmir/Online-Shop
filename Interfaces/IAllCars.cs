﻿using Asp.NetMvcApp.Models;

namespace Asp.NetMvcApp.Interfaces
{
	public interface IAllCars
	{
		IEnumerable<Car> Cars { get;  }
		IEnumerable<Car> getFavCars { get; }
		Car getObjectCar(int carId);
	}
}
