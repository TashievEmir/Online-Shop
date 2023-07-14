using Asp.NetMvcApp.Interfaces;
using Asp.NetMvcApp.Models;

namespace Asp.NetMvcApp.Mocks
{
	public class MockCategory : ICarsCategory
	{
		public IEnumerable<Category> AllCategories
		{
			get {
				return new List<Category>()
				{
					new Category
					{
						Name = "ElectroMobile",
						desc = "Engine on electricity"					},
					new Category
					{
						Name = "Classic",
						desc = "Engine on oil"
					}
				};
			}
		}
	}
}
