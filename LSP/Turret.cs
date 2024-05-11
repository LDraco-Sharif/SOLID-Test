using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Test.LSP
{
    public class Turret : Enemy
    {
        public Turret(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine(name + ": Shoots player from afar");
        }

        //public override void Move()
        //{
        //    Console.WriteLine("Error:" + name + " cannot actually move");
        //}
    }
}
