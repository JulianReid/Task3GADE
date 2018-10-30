using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWTASK_3.Properties
{
    class Map
    {
        private const int MAXRANDOMUNITS = 50;
        public const string FIELDSYMBOL = ".";
        private string[,] grid = new string[20, 20];
        private List<Unit> unitsOnMap = new List<Unit>();
        private List<Building> buildingsOnMap = new List<Building>();
        private int numberOfUnitsOnMap = 0;

        public int NumberOfUnitsOnMap
        {
            get { return numberOfUnitsOnMap; }
            set { numberOfUnitsOnMap = value; }
        }
        public string[,] Grid
        {
            get { return grid; }
        }

        public List<Unit> UnitsOnMap
        {
            get { return unitsOnMap; }
        }
        public List<Building> BuildingOnMap
        {
            get { return buildingsOnMap; }
        }
        public void clearField()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    grid[i, j] = FIELDSYMBOL;

                }
            }
        }
        public void populate()
        {
            Random rnd = new Random();
            int numberOfRandomUnits = rnd.Next(0, MAXRANDOMUNITS) + 1;

            int x, y, randomAttackRange;
            bool atttackOption;
            string team;

            clearField();

            RecourceBuilding rB = new RecourceBuilding(5, 5, 100, "RED", "$");
            grid[5, 5] = rB.Symbol;
            BuildingOnMap.Add(rB);
            FactoryBuilding fB = new FactoryBuilding(10, 10, 100, "GREEN", "@");
            grid[10, 10] = fB.Symbol;
            BuildingOnMap.Add(fB);

            MeleeUnit mU = new MeleeUnit(xPosition, yPosition, )

        }


    }
}
