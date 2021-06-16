using System;
using System.Threading;
using WarriorWarrs.Enum;

namespace WarriorWarrs
{
    class Program
    {
        static Random rng = new Random();
        static void Main(string[] args)
        {
            

            Warrior goodGuy = new Warrior("Sir Johnson", Faction.GoodGuy);
            Warrior badGuy = new Warrior("Sir Evilstain", Faction.BadGuy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if(rng.Next(0, 10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }

                Thread.Sleep(200);
            }
        }
    }
}
