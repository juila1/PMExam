using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPM
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            Console.WriteLine("Some random: " + rand.Next());
            Console.ReadKey();
        }
    }
}
