using BusinessLaag;
using System;

namespace ClientPresentatieLaag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BierenService bierenService = new BierenService();
            var result = bierenService.GeefAlleBierenVoorSoort();
            Console.ReadKey();
        }
    }
}
