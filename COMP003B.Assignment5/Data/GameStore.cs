using COMP003B.Assignment5.Models;

namespace COMP003B.Assignment5.Data;

public static class GameStore
{
	public static List<Game> Games { get; } = new()
	{
		new Game { Id = 1, Name = "Tekken 8", Price = 59.99m },
		new Game { Id = 2, Name = "The Legend of Zelda: Breath of the Wild", Price = 59.99m },
		new Game { Id = 3, Name = "The Legend of Zelda: Breath of the Wild - Nintendo Switch 2 Edition", Price = 69.99m },
		new Game { Id = 4, Name = "The Legend of Zelda: Tears of the Kingdom", Price = 69.99m },
		new Game { Id = 5, Name = "The Legend of Zelda: Tears of the Kingdom - Nintendo Switch 2 Edition", Price = 79.99m },
		new Game { Id = 6, Name = "Elden Ring", Price = 59.99m },
		new Game { Id = 7, Name = "Super Smash Bros. Ultimate", Price = 59.99m },
	};
}