using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1JulainReid
{
    class FactoryBuilding : Building
    {
        protected int unitsToProduce;
        protected int tickPerProduction;
        protected int spawnPoint;

        public FactoryBuilding(int xPosition, int yPosition, int health, string team, string symbol) : base(xPosition, yPosition, health, team, symbol)
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
        {
            get { return symbol; }
            set { symbol = value; }
        }

        public int UnitsToProduce
        {
            get { return unitsToProduce; }
            set { unitsToProduce = value; }
        }        
        public int TickPerProduction
        {
            get { return tickPerProduction; }
            set { tickPerProduction = value; }
        }
        public int SpawnPoint
        {
            get { return spawnPoint; }
            set { spawnPoint = value; }
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

        public void SpawnNewUnits(int TicksPerProdcuction)
        {

        }

        public override string toString()
        {
            string output = "x : " + xPosition + Environment.NewLine
               + "y : " + yPosition + Environment.NewLine
               + "Health : " + health + Environment.NewLine
               + "Units to Produce : " + unitsToProduce + Environment.NewLine
               + "Team : " + team + Environment.NewLine
               + "Symbol : " + symbol + Environment.NewLine;
            return output;
        }


    }
}
