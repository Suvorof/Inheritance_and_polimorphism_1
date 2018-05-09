using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polimorphism_1
{

    class Program
    {
        static void Main()
        {
            ClassRoom cRoom = new ClassRoom(new ExcelentPupil(), new GoodPupil(), new BadPupil(), new GoodPupil());

            cRoom.PrintInfoStudy();
            cRoom.PrintInfoRead();
            cRoom.PrintInfoWrite();
            cRoom.PrintInfoRelax();

            Console.ReadKey();
        }
    }
}
