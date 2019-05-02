using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1P3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    static class AnimalData
    {
        public static string Name;
    }

    class Cat : IInterface
    {

        string strC = AnimalData.Name;
        public string Talk(string str)
        {
            Sound.Sonido();
            return str;
        }
    }

    class Dog : IInterface
    {
        string strD = AnimalData.Name;
        public string Talk(string str)
        {
            throw new NotImplementedException();
        }
    }

    interface IInterface
    {
        string Talk(string str);
    }

    class Sound
    {
        public static void Sonido()
        {

        }
    }
}
