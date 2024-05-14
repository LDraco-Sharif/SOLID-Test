using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Test.LSP
{
    public class Swordsman : IMovingEnemy //IEnemy
    {
        private readonly string _name;
        public Swordsman(string name)
        {
            _name = name;
        }

        public void Attack()
        {
            Console.WriteLine(_name + ": Moves near the player");
        }

        public void Move()
        {
            Console.WriteLine(_name + ": Attacks the player with sword");
        }
    }
}
