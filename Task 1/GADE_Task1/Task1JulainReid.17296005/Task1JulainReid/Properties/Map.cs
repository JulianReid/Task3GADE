using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1JulainReid.Properties
{
    class Map
    {
        
        protected string[,] map = new string[20, 20];
        private MeleeUnit[] Melee = new MeleeUnit[50];
        private RangedUnit[] Ranged = new RangedUnit[50];
        private int meleeUnitNumber = 0;
        private int rangeUnitNumber = 0;
        public string unitSymbol;
        

        //New map, maps out the 20x20 map and then displays the map as stars
        public string newMap()
        {
            string OutputMap = "";

            for(int i = 0; i < 20; i++)
            {
                for(int j = 0; j < 20; j++)
                {
                    map[i, j] = "*";

                }
              
            }

            for(int i = 0; i < 20; i++)
            {
                for(int j = 0; j < 20; j++)
                {
                    OutputMap += map[i, j];
                }
                OutputMap += "\n";
            }
            return OutputMap;

        }
      

        public void newMeleePositions(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "M";





        }
        public void newRangePositions(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "R";
        }
        //Show units will display the units on the map and will be called every time the timer ticks
        public void ShowUnits()
        {
            Random rnd = new Random();
            meleeUnitNumber = rnd.Next(25, 50);
            int X, Y;

            for(int i = 0; i < meleeUnitNumber; i++)
            {
                X = rnd.Next(0, 20);
                Y = rnd.Next(0, 20);
                Melee[i] = new MeleeUnit();
                newMeleePositions(X, Y);

            }

            rangeUnitNumber = rnd.Next(25, 50);
            for (int i = 0; i < rangeUnitNumber; i++)
            {
                X = rnd.Next(0, 20);
                Y = rnd.Next(0, 20);
                Ranged[i] = new RangedUnit();
                newRangePositions(X, Y);
            }
        }
    }
}
