using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombiesversusNinjas
{
    class Program
    {
        class Entity
        {
            private int Health;
            private int Attack;
            private string Name;
            protected int health;
            protected int attack;
            Entity() { }
            Entity(int h, int att)
            {
                Health = h;
                Attack = att;
            }
            public virtual bool ATTACK(Entity);
        }
        static void Main(string[] args)
        {
        }
    }
}
