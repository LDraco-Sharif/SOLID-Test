using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Test.LSP
{
    public class Swordsman : MovingEnemy //Enemy
    {
        public Swordsman(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine(name + ": Moves near the player");
        }

        public override void Move()
        {
            Console.WriteLine(name + ": Attacks the player with sword");
        }
    }
}
