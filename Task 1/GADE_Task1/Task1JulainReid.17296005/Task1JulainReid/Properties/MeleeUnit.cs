using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1JulainReid.Properties
{
    public class MeleeUnit : Unit
    {
        public MeleeUnit(int Xposition, int Yposition, int Health, int Speed, int Attack, int Attackrange, string Team, string Symbol) : base(Xposition, Yposition, Health, Speed, Attack, Attackrange, Team, Symbol)
        {
            this.xPosition = Xposition; 
            this.yPosition = Yposition;
            this.health = Health = 100;
            this.speed = Speed = -1;
            this.attack = Attack;
            this.attackRange = Attackrange = 1;
            this.team = Team;
            this.symbol = Symbol;
        }

       

        public int Xposition { get { return xPosition; } }
        public int Yposition { get { return yPosition; } }
        public int Health { get { return health; } set { health = value; } }
        public int Speed { get { return speed; } }
        public int Attack { get { return attack; } }
        public int AttackRange { get { return attackRange; } }
        public string Team { get { return team; } }
        public string Symbol { get { return symbol; } }



       

        public override void move(int Xposition, int Yposition)
        {
            Random rnd = new Random();
            int X, Y;

            for (int i = 0; i > 1; i++)
            {
                X = rnd.Next(1, 3);
                Y = rnd.Next(1, 3);

                Xposition = X;
                Yposition = Y;


            }
        }
        
        public override void combat()
        {
            Random Damage = new Random();

            int hit = Damage.Next(1, 100);
            
            if(hit >= 1 && hit <= 100)
            {
                Health = Health - hit;

            }
            
        }
       

        public override void isclosestUnit()
        {
            
        }
        //If health is less than 0, the statement is true. 
        public override bool isunitDead()
        {
           if(health <= 0)
            {
             return true;

            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string output = "x : " + xPosition + Environment.NewLine
                + "y : " + yPosition + Environment.NewLine
                + "Health : " + health + Environment.NewLine
                + "Speed : " + speed + Environment.NewLine
                + "Attack : " + attack + Environment.NewLine
                + "Attack Range" + attackRange + Environment.NewLine
                + "Team : " + team + Environment.NewLine
                + "Symbol : " + symbol + Environment.NewLine;
            return output;
        }


    }
}
