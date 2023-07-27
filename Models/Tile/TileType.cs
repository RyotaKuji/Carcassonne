using static Carcassonne.Definitions;

namespace Carcassonne.Models.Tile
{
	abstract class TileType
	{
		int no;
		public TileType(int no)
		{
			if (no >= TILE_TYPE_NUM)
			{
				throw new();
			}
			this.no = no;
		}
	}
}
