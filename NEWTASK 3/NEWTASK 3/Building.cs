using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWTASK_3.Properties
{
    abstract class Building
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
        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }
        

        Building()
        {

        }

        public virtual bool isAlive()
        {
            return false;
        }

        public virtual string toString()
        {
            return " ";
        }


    }
}
