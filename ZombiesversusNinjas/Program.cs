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
            public Entity() { }
            public Entity(int h, int a)
            {
                Health = h;
                Attack = a;
            }
            public virtual bool ATTACK(Entity)
            {
                return false;
            }
        }
        class Zombie : Entity
            {
            Zombie() { }
            Zombie(int h, int a)
            {
                health = h;
                attack = a;
                }
        }

        class Player : Entity
        {
            Player() { }
            Player(int h, int a)
            {
                health = h;
                attack = a;
            }
            public override bool ATTACK(Entity )
            {
                return base.ATTACK();
            }
            public bool Defend()
            {

            }
        }

        static void Main(string[] args)
        {
        }
    }
}
