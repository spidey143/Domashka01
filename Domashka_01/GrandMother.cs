using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_01
{
    public class GrandMother: Human
    {
        public GrandFather GrandFather { get; set; }
        public Tool Tool { get; set; }
    }
}
