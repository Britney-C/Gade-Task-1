using System;
using System.Collections.Generic;
using System.Text;

namespace GadeTask1
{
	//Question 2.1
	abstract class Tile
	{
		protected int X 
		{
			get
			{
				return X;
			}
			set
			{

			}
		}

		protected int Y
		{
			get
			{
				return Y;
			}
			set
			{

			}
		}

		public enum TileType
		{
			Hero = 0,
			Enemy = 1,
			Gold = 2,
			Weapon = 3
		}

		//Constructor that recieves and sets inital values for the variables. THis exists to border the map with obstacles that the player can't move past.
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

		//Subclass that calls the bass class's constructor with X and Y paramenters
		 class Obstacle : Tile
		{
			public Obstacle(int xPosition, int yPosition) : base()
			{
				base.X = xPosition;
				base.Y = yPosition;
			}
		}

		//Identical to Obstacle, but exisits to denote an empty tile
		public class EmptyTile : Tile
		{
			public EmptyTile(int xPosition, int yPosition) : base()
			{
				base.X = xPosition;
				base.Y = yPosition;
			}
		}
	}
}

