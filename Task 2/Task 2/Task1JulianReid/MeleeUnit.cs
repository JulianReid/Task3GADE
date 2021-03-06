﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1JulainReid.Properties
{
    public class MeleeUnit : Unit
    {
        public MeleeUnit(int xPosition, int yPosition, int health, int speed, int attack, int attackRange, string team, string symbol, string name) : base(xPosition, yPosition, health, speed, attack, attackRange, team, symbol, name)
        {
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
                health = health - hit;
            }            
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

        public override void isclosestUnit()
        {
            
        }
        //If health is less than 0, the statement is true.
        public override bool isunitDead()
        {
           if(health >= 0)
            {
             return true;

            }
            else
            {
                return false;
            }
        }

    }
}
