using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Static_Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Songs song1 = new Songs("Holiday","John",115);
            Songs song2 = new Songs("Billy Eish", "Goodnight", 155);
            Console.WriteLine(song1.title);
            Console.WriteLine(Songs.songCount);


            //freeze console
            Console.ReadLine();
        }
    }
}
