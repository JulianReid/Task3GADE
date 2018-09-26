using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1JulainReid.Properties
{

    //Useing virtual methods becuase no code will be implemented into the base class

        public abstract class Unit
    {
        
        protected int xPosition;
        protected int yPosition;
        protected int health = 100;
        protected int speed;
        protected int attack;
        protected int attackRange;
        protected string team;
        protected string symbol;

        

        public Unit(int Xposition, int Yposition, int Health, int Speed, int Attack, int Attackrange, string Team, string Symbol)
        {
            this.xPosition = Xposition;
            this.yPosition = Yposition;
            this.health = Health;
            this.speed = Speed;
            this.attack = Attack;
            this.attackRange = Attackrange;
            this.team = Team;
            this.symbol = Symbol;

        }

       

        public virtual void move(int Xposition, int Yposition)
        {
            
        }

        public virtual void combat()
        {
            
        }

        public virtual bool iswithinattackrange(int unitU)
        {
            return true;
        }

        public virtual void isclosestUnit()
        {

        }

        public virtual bool isunitDead()
        {
            return true;
        }

        public virtual string ToString()
        {
            string output = "";

            return output;

        }
    }
}
