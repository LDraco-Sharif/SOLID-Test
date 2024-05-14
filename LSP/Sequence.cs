using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Test.ISP
{
    public class Sequence
    {
        public virtual object ReturnSequence()
        {
            //Random code

            return new 
            {
                value = "Something"
            };                
        }
    }
}
