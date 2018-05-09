using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polimorphism_1
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad pupil have bad skill of studying");
        }
        public override void Read()
        {
            Console.WriteLine("Bad pupil have bad skill of reading");
        }
        public override void Write()
        {
            Console.WriteLine("Bad pupil have bad skill of writing");
        }
        public override void Relax()
        {
            Console.WriteLine("Bad pupil always relax");
        }
    }
}
