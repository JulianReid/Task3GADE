using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1JulainReid
{
    class Building
    {
        protected int xPosition;
        protected int yPosition;
        protected int health;
        protected string team;
        protected string symbol;

        public Building(int xPosition, int yPosition, int health, string team, string symbol)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
            this.health = health;
            this.team = team;
            this.symbol = symbol;
        }

        public virtual bool isdead()
        {
            return false;
        }

        public virtual string toString()
        {
            return " ";
        }

        public virtual void read()
        {

        }

        



    }
}
