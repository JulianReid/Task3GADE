using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1JulainReid
{
    class RecourceBuilding : Building
    {
        protected string recourceType;
        protected int recourcesPerTick;
        protected int recourcesRemaining;
      



        public RecourceBuilding(int xPosition, int yPosition, int health, string team, string symbol) : base(xPosition, yPosition, health, team, symbol)
        {
        }

        public int Xposition
        {
            get { return xPosition; }
            set { xPosition = value; }
        } 

        public int Ypostion
        {
            get { return xPosition; }
            set { xPosition = value; }
        }
        public int Health
        {
            get { return Health; }
            set { health = value; }
        }

        public string Team
        {
            get { return team; }
            set { team = value; }
        }
        public string Symbol
        { get { return symbol; }
            set { symbol = value; }
        }
        public string RecourceType
        {
            get { return recourceType; }
            set { recourceType = value; }
        }

        public int RecourcesPerTick
        {
            get { return recourcesPerTick; }
            set { recourcesPerTick = value; }

        }
        public int RecourcesRemaining
        {
            get { return recourcesRemaining; }
            set { recourcesRemaining = value; }
        }


        public override bool isdead()
        {
            if(Health <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void generateRecources()
        {
            
        }

        public override string toString()
        {
            string output = "x : " + xPosition + Environment.NewLine
               + "y : " + yPosition + Environment.NewLine
               + "Health : " + health + Environment.NewLine
               + "Recource type : " + recourceType + Environment.NewLine
               + "Recources remaining : " + recourceType + Environment.NewLine
               + "Team : " + team + Environment.NewLine
               + "Symbol : " + symbol + Environment.NewLine;
            return output;
        }
    }
}
