using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_01
{
    public class Chicken: Animal
    {
        public Human Human { get; set; }
        public List<Egg> eggs = new List<Egg>();
    }
}
