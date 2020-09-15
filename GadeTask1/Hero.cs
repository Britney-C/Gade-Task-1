using System;
using System.Collections.Generic;
using System.Text;

namespace GadeTask1
{
    class Hero : Character
    {
        //Question 2.6 : Concrete Hero subclass, which inherits from Character.
        public Hero(int positionX, int positionY, int heroHP) : base(positionX, positionY)
        {
            //The Hero constructor receives X and Y position and HP.
            //It should then set the HP and max HP of the hero based on the parameter.
            //Additionally, a Hero’s damage is always 2.

            base.damage = 2;
            base.maxHP = heroHP;
        }

        public ReturnMove(Character.Movement movement)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            //An overridden ToString() method: This returns the formatted Player Stats as shown below:
            //      Player Stats:
            //      HP: HP / Max HP
            //      Damage: 2
            //      [X, Y]

            return $"Player Stats: \n HP: {base.HP} / {base.maxHP} \n Damage: {base.damage} \n ({base.X} , {base.Y})";
        }
    }
}
