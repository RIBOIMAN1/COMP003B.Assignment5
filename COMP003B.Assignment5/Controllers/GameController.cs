using COMP003B.Assignment5.Data;
using COMP003B.Assignment5.Models;
using Microsoft.AspNetCore.Mvc;
namespace COMP003B.Assignment5.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class GameController : ControllerBase
	{
		[HttpGet]
		public ActionResult<List<Game>> GetGames()
		{
			return Ok(GameStore.Games);
		}
		[HttpGet("{id}")]
		public ActionResult<Game> GetGame(int id)
		{
			var game = GameStore.Games.FirstOrDefault(p => p.Id == id);

			if (game is null)
				return NotFound();

			return Ok(game);
		}
		[HttpPost]
		public ActionResult<Game> CreateGame(Game game)
		{
			game.Id = GameStore.Games.Max(p => p.Id) + 1;
			GameStore.Games.Add(game);

			return CreatedAtAction(nameof(GetGame), new { id = game.Id }, game);
		}
		[HttpPut("{id}")]
		public IActionResult UpdateGame(int id, Game updatedGame)
		{
			var existingGame = GameStore.Games.FirstOrDefault(p => p.Id == id);

			if (existingGame is null)
				return NotFound();

			existingGame.Name = updatedGame.Name;
			existingGame.Price = updatedGame.Price;

			return NoContent();
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteGame(int id)
		{
			var game = GameStore.Games.FirstOrDefault(p => p.Id == id);

			if (game is null)
				return NotFound();

			GameStore.Games.Remove(game);

			return NoContent();
		}
	}
}