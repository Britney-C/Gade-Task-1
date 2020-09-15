using System;
using System.Collections.Generic;
using System.Text;

namespace GadeTask1
{
	abstract class Character : Tile
	{
		protected int HP;
		protected int maxHP;
		protected int damage;

		enum Movement
		{
			No_movement,
			Up,
			Down,
			Left,
			Right
		}

		public int accessHP { get; set; }
		public int accessMaxHP { get; set; }
		public int accessDamage { get; set; }
	}
}
