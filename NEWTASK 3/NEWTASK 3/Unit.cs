using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWTASK_3
{
    abstract class Unit
    {
        protected int xPosition;
        protected int yPosition;
        protected int health = 100;
        protected int speed;
        protected int attack;
        protected int attackRange;
        protected string team;
        protected string symbol;
        protected string name;

        public Unit(int xPosition, int yPosition, int health, int speed, int attack, int attackRange, string team, string symbol, string name)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
            this.health = health;
            this.speed = speed;
            this.attack = attack;
            this.attackRange = attackRange;
            this.team = team;
            this.symbol = symbol;
            this.name = name;
        }
        public int Xpositon
        {
            get { return xPosition; }
            set { xPosition = value; }
        }
        public int Yposititon
        {
            get { return yPosition; }
            set { yPosition = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }
        public int AttackRange
        {
            get { return attackRange; }
            set { attackRange = value; }
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
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        Unit()
        {

        }
        public abstract void move(int xPosition, int yPosition);
        public abstract void combat(Unit enemy);
        public abstract bool isWithInAttackrange(Unit enemy);
        public abstract Unit isClosestUnit(List<Unit> list);
        public abstract bool isAlive();
        public abstract string toString();
    }
}
