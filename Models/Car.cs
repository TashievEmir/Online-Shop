namespace Asp.NetMvcApp.Models
{
	public class Car
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string shortDesc { get; set; }
		public string longDesc { get; set; }
		public string Img { get; set; }
		public ushort Price { get; set; }
		public bool isFavourite { get; set; }
		public bool Available { get; set; }
		public int CategoryId { get; set; }
		public virtual Category Category { get; set; }
	}
}
