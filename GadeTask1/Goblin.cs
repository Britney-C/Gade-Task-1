using System;
using System.Collections.Generic;
using System.Text;

namespace GadeTask1
{
    class Goblin : Enemy
    {
        //Question 2.5 : Concrete Goblin class which inherits Enemy.

        protected int[,] enemyVisionArray = { };

        public Goblin(int _X, int _Y, int enemyHP = 10, int enemyDamage = 1) : base(enemyHP, enemyDamage, _X, _Y, "Goblin", 'G')
        {
        }

        public virtual Tile ReturnMove(Movement random)
        {
            return null;
        }

        //public override string ReturnMove()
    }
}
