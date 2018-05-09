using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polimorphism_1
{
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Exelent pupil have excelent skill of studying");
        }
        public override void Read()
        {
            Console.WriteLine("Exelent pupil have excelent skill of reading");
        }
        public override void Write()
        {
            Console.WriteLine("Exelent pupil have excelent skill of writing");
        }
        public override void Relax()
        {
            Console.WriteLine("Exelent pupil relax rarely");
        }
    }
}
