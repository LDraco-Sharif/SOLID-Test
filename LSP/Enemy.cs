using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Test.LSP
{
    public class Enemy
    {
        protected string name;

        public Enemy(string name)
        {
            this.name = name;
        }

        //virtual public void Move()
        //{
        //    Console.WriteLine("Move");
        //}
        virtual public void Attack()
        {
            Console.WriteLine(name + ": Attack");
        }

    }

    public class MovingEnemy : Enemy
    {
        public MovingEnemy(string name) : base(name)
        {
        }

        virtual public void Move()
        {
            Console.WriteLine(name + ": Move");
        }
    }
}
