using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWTASK_3.Properties
{
    class FactoryBuilding : Building
    {
        protected int unitsToProduce;
        protected int tickPerProduction;
        protected int spawnPointX;
        private int spawnPointY;

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
        public int SpawnPointX
        {
            get { return spawnPointX; }
            set { spawnPointX = value; }
        }
        public int SpawnPointY
        {
            get { return spawnPointX; }
            set { spawnPointY = value; }
        }

        public FactoryBuilding(int xPosition, int yPosition, int health, string team, string symbol) : 
            base(xPosition, yPosition, health, team, symbol)
        {
            
        }

        public override bool isAlive()
        {
            if (health > 0)
                return true;
            else
                return false;
        }

        public Unit spawnNewUnit()
        {
            if (unitsToProduce > 0)
            {
                Random rnd = new Random();
                if (rnd.Next(0, 3) == 0)
                {
                    MeleeUnit mU = new MeleeUnit(spawnPointX, spawnPointY, 100, -1, 3, 1, this.team, "M", "Knife");
                    unitsToProduce++;
                    return mU;
                }
                else
                {
                    RangedUnit rU = new RangedUnit(spawnPointX, spawnPointY, 100, -1, 6, 1, this.team, "R", "Gun");
                    unitsToProduce++;
                    return rU;
                }
            }
            else
                return null;
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
