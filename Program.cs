using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            WorldClass worldClass = new WorldClass();
            worldClass.Run();
            Console.ReadKey();
        }
    }
}
