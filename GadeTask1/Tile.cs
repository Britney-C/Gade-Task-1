using System;
using System.Collections.Generic;
using System.Text;

namespace GadeTask1
{
	abstract class Tile
	{
		protected int X { get; set; }
		protected int Y { get; set; }

		public enum TileType
		{
			Hero = 0,
			Enemy = 1,
			Gold = 2,
			Weapon = 3
		}

		public Tile()
		{
			X = 0;
			Y = 0;
			char hero = 'H';
			char enemy = 'E';
			char gold = 'G';
			char weapon = 'W';
			hero = (char)TileType.Hero;
			enemy = (char)TileType.Enemy;
			gold = (char)TileType.Gold;
			weapon = (char)TileType.Weapon;
		}

		 class Obstacle : Tile
		{
			public Obstacle(int xPosition, int yPosition, char symbol)
			{
				xPosition = base.X;
				yPosition = base.Y;
			}
		}

		public class EmptyTile : Tile
		{
			public EmptyTile(int xPosition, int yPosition)
			{
				Console.WriteLine(".");

				xPosition = base.X;
				yPosition = base.Y;
			}
		}
	}
}
}
