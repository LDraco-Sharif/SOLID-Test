using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Test.ISP
{
    public class RandomSequence : Sequence
    {
        public override object ReturnSequence()
        {
            //Random Code

            return new 
            { 
                message = "Message"
            };
        }

    }
}
