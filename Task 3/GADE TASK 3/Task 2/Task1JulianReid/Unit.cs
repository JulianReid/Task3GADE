using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1JulainReid.Properties
{
        public abstract class Unit
    {
        //combat is void, attackrange is a bool name iswithinattackrange parameter unitU, void closestunit, 
        protected int xPosition;
        protected int yPosition;
        protected int health = 100;
        protected int speed;
        protected int attack;
        protected int attackRange;
        protected string team;
        protected string symbol;
        protected string name;

       
        public Unit(int xPosition, int yPosition, int health, int speed, int attack, int attackRange, string team, string symbol, string name)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
            this.health = health;
            this.speed = speed;
            this.attack = attack;
            this.attackRange = attackRange;
            this.team = team;
            this.symbol = symbol;
            this.name = name;

        }


        Unit()
        {

        }

        public abstract void move(int xPosition, int yPosition);
        public abstract void combat(Unit enemy);
        public abstract bool isWithInAttackrange(Unit enemy);
        public abstract void isClosestUnit();
        public abstract bool isAlive();
        public abstract string toString();


       

        public virtual void read()
        {

        }
    }
}
