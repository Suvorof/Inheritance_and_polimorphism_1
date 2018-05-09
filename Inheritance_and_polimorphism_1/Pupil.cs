using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polimorphism_1
{
    class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Standard skill of studying");
        }
        public virtual void Read()
        {
            Console.WriteLine("Standard skill of reading");
        }
        public virtual void Write()
        {
            Console.WriteLine("Standard skill of writing");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Standard skill of relaxing");
        }
    }
}
