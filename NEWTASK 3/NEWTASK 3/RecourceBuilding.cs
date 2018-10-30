using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWTASK_3.Properties
{
    class RecourceBuilding : Building
    {
        private string recourceType;
        private int recourcesPerTick;
        private int recourcesRemaining;
        private string RecourceType
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
        public RecourceBuilding(int xPosition, int yPosition, int health, string team, string symbol) : 
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
        
        public void generateRecources()
        {
            if (recourcesRemaining >= 0)
                recourcesRemaining -= recourcesPerTick;
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
