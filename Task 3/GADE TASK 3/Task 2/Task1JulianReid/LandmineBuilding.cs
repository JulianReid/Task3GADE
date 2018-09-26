using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1JulainReid
{
    class LandmineBuilding : Building
    {
        protected int attack;

        public LandmineBuilding(int xPosition, int yPosition, int health, string team, string symbol) : base(xPosition, yPosition, health, team, symbol)
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
            set { health = 100; }
        }

        public string Team
        {
            get { return team; }
            set { team = value; }
        }
        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        public int Attack
        {
            get { return attack; }
            set { attack = 50; }
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

        public void detonate()
        {

        }

        public override string toString()
        {
            string output = "x : " + xPosition + Environment.NewLine
               + "y : " + yPosition + Environment.NewLine
               + "Health : " + health + Environment.NewLine
               + "Attack : " + attack + Environment.NewLine
               + "Team : " + team + Environment.NewLine
               + "Symbol : " + symbol + Environment.NewLine;
               
            return output;
        }

    }
}
