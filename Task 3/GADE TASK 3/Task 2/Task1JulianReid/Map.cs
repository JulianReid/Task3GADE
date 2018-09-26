using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1JulainReid.Properties
{
    class Map
    {


        protected string[,] map = new string[30, 30];
        private MeleeUnit[] Melee = new MeleeUnit[50];
        private RangedUnit[] Ranged = new RangedUnit[50];
        private int meleeUnitNumber = 0;
        private int rangeUnitNumber = 0; 
        public string unitSymbol;
        private HealerUnit[] Healer = new HealerUnit[20];
        private int healerUnitNumber = 0;
        private StrongUnit[] strong = new StrongUnit[5];
        private int strongUnitNumber = 0;
        private FactoryBuilding[] factory = new FactoryBuilding[4];
        private int factoryBuildignumber = 0;
        private RecourceBuilding[] recource = new RecourceBuilding[4];
        private int recourceBuildingNumber = 0;
        private FootUnit[] Foot = new FootUnit[30];
        private int footUnitNumber = 0;
        private LandmineBuilding[] landmine = new LandmineBuilding[5];
        private int landmineBuildingNumber = 5;
        public void team()
        {
            
        }



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

        private void LandminePositions(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "L";
        }

        private void newFootPosition(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "F";
        }

        private void RecourcePositions(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "X";
        }
        private void FactoryPositions(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "F";
        }


        public void newMeleePositions(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "M";
        }
        public void newRangePositions(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "R";
        }

        public void newHealerPositions(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "H";
        }
        public void newStrongPositions(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "S";
        }
        

        public void ShowUnits()
        {
            Random rnd = new Random();
            meleeUnitNumber = rnd.Next(25, 50);
            int X, Y;

            for(int i = 0; i < meleeUnitNumber; i++)
            {
                X = rnd.Next(0, 30);
                Y = rnd.Next(0, 30);
                Melee[i] = new MeleeUnit(X, Y, 100, 2, 50, 2, "melee", "M", "Melee");
                newMeleePositions(X, Y);

            }

            rangeUnitNumber = rnd.Next(25, 50);
            for (int i = 0; i < rangeUnitNumber; i++)
            {
                X = rnd.Next(0, 30);
                Y = rnd.Next(0, 30);
                Ranged[i] = new RangedUnit(X, Y, 100, 3, 50, 3, "ranged", "R", "Ranged");
                newRangePositions(X, Y);
            }

            healerUnitNumber = rnd.Next(0, 20);
            for (int i = 0; i < meleeUnitNumber; i++)
            {
                X = rnd.Next(0, 30);
                Y = rnd.Next(0, 30);
                Healer[i] = new HealerUnit();
                newHealerPositions(X, Y);
            }

            strongUnitNumber = rnd.Next(0, 5);
            for (int i = 0; i < strongUnitNumber; i++)
            {
                X = rnd.Next(0, 30);
                Y = rnd.Next(0, 30);
                strong[i] = new StrongUnit();
                newStrongPositions(X, Y);
            }

            
            footUnitNumber = rnd.Next(0, 30);
            for (int i = 0; i <= footUnitNumber; i++)
            {
                X = rnd.Next(0, 20);
                Y = rnd.Next(0, 20);
                Foot[i] = new FootUnit();
            }



        }
        //The show buildings method is seprate to the show units method because the show building method will not be updated with the timer
        public void ShowBuildings()
        {
            int X, Y;
            Random rnd = new Random();
            factoryBuildignumber = 4;
            for (int i = 0; i < factoryBuildignumber; i++)
            {
                X = rnd.Next(0, 20);
                Y = rnd.Next(0, 20);
                factory[i] = new FactoryBuilding();
                FactoryPositions(X, Y);
            }
            recourceBuildingNumber = 4;
            for (int i = 4; i < recourceBuildingNumber; i++)
            {
                X = rnd.Next(0, 20);
                Y = rnd.Next(0, 20);
                recource[i] = new RecourceBuilding();
                RecourcePositions(X, Y);

            }
            landmineBuildingNumber = 5;
            for (int i = 5; i < landmineBuildingNumber; i++)
            {
                X = rnd.Next(0, 20);
                Y = rnd.Next(0, 20);
                landmine[i] = new LandmineBuilding();
                LandminePositions(X, Y);
            
            }


        }
    }
}
