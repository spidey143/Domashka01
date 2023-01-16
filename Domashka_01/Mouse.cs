using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_01
{
    public class Mouse: Animal
    {
        Tail tail;
        public Mouse() { 
            tail = new Tail();
        }
    }
}
