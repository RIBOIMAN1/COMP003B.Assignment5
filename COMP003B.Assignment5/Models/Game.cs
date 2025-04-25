namespace COMP003B.Assignment5.Models
{
	public class Game
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public decimal Price { get; set; }
		public string Genre { get; set; } = string.Empty;
		public DateTime ReleaseDate { get; set; }
	}
}