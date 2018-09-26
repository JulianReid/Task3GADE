using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1JulainReid.Properties
{
    class Map
    {
        //All the different instances of the other classes

        protected string[,] map = new string[20, 20];
        private MeleeUnit[] Melee = new MeleeUnit[50];
        private RangedUnit[] Ranged = new RangedUnit[50];
        private FactoryBuilding[] factory = new FactoryBuilding[4];
        private RecourceBuilding[] recource = new RecourceBuilding[4];
        private int meleeUnitNumber = 0;
        private int rangeUnitNumber;
        public string unitSymbol;
        private int factoryBuildignumber = 0;
        private int recourceBuildingNumber = 0;

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
        private void newFactoryPositions(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "F";
        }
         private void newRecourcePositions(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "X";
        }

        //This now places the units and the buildings on the map
        public void ShowUnits()
        {
            Random rnd = new Random();
            meleeUnitNumber = rnd.Next(25, 50);
            int X, Y;

            for(int i = 0; i < meleeUnitNumber; i++)
            {
                X = rnd.Next(0, 20);
                Y = rnd.Next(0, 20);
                Melee[i] = new MeleeUnit(X, Y, 100, -1, 1, 1, , "M");
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

        private void ShowBuilding()
        {
            Random rnd = new Random();
            int X, Y;
            factoryBuildignumber = 4;
            for (int i = 0; i < factoryBuildignumber; i++)
            {
                X = rnd.Next(0, 20);
                Y = rnd.Next(0, 20);
                factory[i] = new FactoryBuilding();
                newFactoryPositions(X, Y);
            }

            recourceBuildingNumber = 4;
            for (int i = 4; i < recourceBuildingNumber; i++)
            {
                X = rnd.Next(0, 20);
                Y = rnd.Next(0, 20);
                recource[i] = new RecourceBuilding();
                newRecourcePositions(X, Y);
            }
        }



    }
}
