using Asp.NetMvcApp.Models;

namespace Asp.NetMvcApp.Interfaces
{
	public interface ICarsCategory
	{
		IEnumerable<Category> AllCategories { get; }
	}
}
