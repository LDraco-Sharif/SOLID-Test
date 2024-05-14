using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Test.LSP
{
    public class Turret : IEnemy
    {
        private readonly string _name;
        public Turret(string name)
        {
            _name = name;
        }
        public void Attack()
        {
            Console.WriteLine(_name + ": Shoots player from afar");
        }

        //public void Move()
        //{
        //    Console.WriteLine("Error:" + name + " cannot actually move");
        //}
    }
}
