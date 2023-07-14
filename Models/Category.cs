namespace Asp.NetMvcApp.Models
{
	public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string desc { get; set; }
		public List<Car> Cars { get; set; }
	}
}
