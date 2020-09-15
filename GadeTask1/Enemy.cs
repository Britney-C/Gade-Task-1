using System;
using System.Collections.Generic;
using System.Text;

namespace GadeTask1
{
    abstract class Enemy : Character
    {
        //Question 2.4 : The abstract Enemy class is inherited from Character.
        protected Random random = new Random();

        //Enemy constructor that receives X and Y positions, the enemy’s damage and it's starting HP(and thus also max HP) and it's symbol.
        //It delegates its X and Y position to the Character subclass via a constructor initialiser, then sets all the relevant member variables.
        public Enemy(int enemyHP, int enemyDamage, int _X, int _Y, string enemyClassName, char enemySymbol = 'E') : base(_X, _Y)
        {
            HP = enemyHP;
            maxHP = HP;
            damage = enemyDamage;
        }

        //An overridden ToString method that, using the enemy’s class, outputs a string that looks as follows:  
        //Enemy Class: at [X, Y] (Amount DMG)
        public override string ToString()
        {
            return $"Enemy Class:  { this.GetType().FullName }  at [  { X } , { Y } ] (  { damage } )";
        }
    }
}
