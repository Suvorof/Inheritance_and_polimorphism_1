using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polimorphism_1
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good pupil have good skill of studying");
        }
        public override void Read()
        {
            Console.WriteLine("Good pupil have good skill of reading");
        }
        public override void Write()
        {
            Console.WriteLine("Good pupil have good skill of writing");
        }
        public override void Relax()
        {
            Console.WriteLine("Good pupil relax more often than the excelent pupil");
        }
    }
}
