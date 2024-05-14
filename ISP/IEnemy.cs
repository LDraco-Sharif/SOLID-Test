using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Test.LSP
{
    public interface IEnemy
    {

        //void Move();
        void Attack();


    }

    public interface IMovingEnemy : IEnemy
    {
        void Move();

    }
}
