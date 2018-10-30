using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWTASK_3
{
    class RangedUnit : Unit
    {

        private const int DAMAGE = 1;
        public RangedUnit(int xPosition, int yPosition, int health, int speed, int attack, int attackRange, string team, string symbol, string name) 
            : base(xPosition, yPosition, health, speed, attack, attackRange, team, symbol, name)
        {
        }

        public override void move(int xPosition, int yPosition)
        {
            Xpositon = xPosition;
            Yposititon = yPosition; 
        }
        public override void combat(Unit enemy)
        {
            if(this.isWithInAttackrange(enemy))
            {
                enemy.Health -= DAMAGE;
            }
        }
        public override bool isWithInAttackrange(Unit enemy)
        {
            if ((Math.Abs(this.Xpositon - enemy.Xpositon) <= this.AttackRange))
                return true;
            else
                return false;          
        }
        public override Unit isClosestUnit(List<Unit> list)
        {
            Unit closest = null;
            int attackRangeX, attackRangeY;
            int shortestRange = 1000; 

            foreach (Unit u in list)
            {
                attackRangeX = Math.Abs(this.Xpositon - u.Xpositon);
                attackRangeY = Math.Abs(this.Yposititon - u.Yposititon);

                if (attackRangeX < shortestRange)
                {
                    shortestRange = attackRangeX;
                    closest = u;
                }
                if (attackRangeY < shortestRange)
                {
                    shortestRange = attackRangeY;
                    closest = u;
                }

            }

            return closest;
        }
        public override bool isAlive()
        {
            if (this.Health <= 0)
                return false;
            else
                return true; 
        }

        public override string toString()
        {
            string output = "x : " + xPosition + Environment.NewLine
                + "y : " + yPosition + Environment.NewLine
                + "Health : " + health + Environment.NewLine
                + "Speed : " + speed + Environment.NewLine
                + "Attack : " + attack + Environment.NewLine
                + "Attack Range" + attackRange + Environment.NewLine
                + "Team : " + team + Environment.NewLine
                + "Symbol : " + symbol + Environment.NewLine
                + "Name : " + name + Environment.NewLine;
            return output;
        }


    }
}
