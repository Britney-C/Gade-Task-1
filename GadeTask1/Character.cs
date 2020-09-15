using System;
using System.Collections.Generic;
using System.Text;

namespace GadeTask1
{
	//Question 2.2 : This is an abstract base class and it inherits from Tile. This is the true base class for your Hero and Goblin classes.
	abstract class Character : Tile
	{
		protected int[,] characterVisionArray = {};
		protected int HP { get; set; }
		protected int maxHP { get; set; }
		protected int damage { get; set; }

		public Character(int positionX, int positionY)
		{
			positionY = base.Y;
			positionX = base.X;
		}

		public enum Movement
		{
			No_movement,
			Up = ConsoleKey.UpArrow,
			Down = ConsoleKey.DownArrow,
			Left = ConsoleKey.LeftArrow,
			Right = ConsoleKey.RightArrow
		}

		//Question 2.3 :  The Character class contains the following methods, most of which define generic implementations for all characters to use.
		public virtual void Attack(Character target)
		{
			target.HP -= damage;
		}

		public bool IsDead()
		{
			if (HP < 1) return true; else return false;
		}

		public virtual bool CheckRange(Character target)
		{
			int distanceToTarget = DistanceTo(target);
			bool bareHanded = true;
			if (bareHanded)
			{
				distanceToTarget = 1;
			}
			return true;
		}

		private int DistanceTo(Character target)
		{
			int spaceX = target.X - X;
			int spaceY = target.Y - Y;
			return Math.Abs(spaceX + spaceY);
		}

		public void Move(Movement move)
		{
			switch (move)
			{
				case Movement.Up:
					Y -= 1;
					break;

				case Movement.Down:
					Y += 1;
					break;

				case Movement.Left:
					X -= 1;
					break;

				case Movement.Right:
					X += 1;
					break;

				default:
					X = X;
					Y = Y;
					break;
			}
		}
	}
}
