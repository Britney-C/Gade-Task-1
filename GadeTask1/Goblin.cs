using System;
using System.Collections.Generic;
using System.Text;

namespace GadeTask1
{
    class Goblin : Enemy
    {
        //Question 2.5 : Concrete Goblin class which inherits Enemy.
        public Goblin(int _X, int _Y, int enemyHP = 10, int enemyDamage = 1) : base(enemyHP, enemyDamage, _X, _Y, "Goblin", 'G')
        {
        }

        public override Movement ReturnMove(Movement move = Movement.No_movement)
        {
            int[] values = (int[])Enum.GetValues(typeof(Character.Movement));
            Random random = new Random();
            Movement movement = (Movement)(values.GetValue(random.Next(values.Length)));
            
            return movement;
        }
    }
}
