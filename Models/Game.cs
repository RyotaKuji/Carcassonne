namespace Carcassonne.Models
{
	class Game
	{
		List<Player> players;
		int turn;
		public Game()
		{
			players = new();
			for (int i = 0; i < 2; i++)
			{
				players.Add(new());
			}
			turn = 0;
		}
	}
}
