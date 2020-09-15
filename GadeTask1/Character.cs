using System;
using System.Collections.Generic;
using System.Text;

namespace GadeTask1
{
	//Question 2.2 : This is an abstract base class and it inherits from Tile. This is the true base class for your Hero and Goblin classes.
	abstract class Character : Tile
	{
		protected int[,] characterVisionArray;
		internal object characterDamaged;

		protected int HP { get; set; }
		protected int maxHP { get; set; }
		protected int damage { get; set; }

		public int[,] getVision()
		{
			return characterVisionArray;
		}
		public void setVision()
		{

		}

		public Character(int positionX, int positionY)
		{
			positionY = base.Y;
			positionX = base.X;
		}

		public enum Movement
		{
			No_movement = 0,
			Up = 1,
			Down = 2,
			Left = 3,
			Right = 4
		}

		//Question 2.3 : Character class contains the following methods, most of which define generic implementations for all characters to use.
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
					break;
			}
		}

		public abstract Movement ReturnMove(Movement move = 0);
		public abstract override string ToString();

	}
}
