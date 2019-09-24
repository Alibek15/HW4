using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    public class tank
    {
        protected string name;
        protected int bullet;
        protected int armor;
        protected int Maneuver;
        public tank(int bullet, int armor, int Maneuver, string name)
        {

            this.bullet = bullet;
            this.armor = armor;
            this.Maneuver = Maneuver;
            this.name = name;
        }
        public tank()
        {
            bullet = 0;
            armor = 0;
            Maneuver = 0;
            name = "null";
        }
        public void Print()
        {
            Console.WriteLine("name - " + name);
            Console.WriteLine("bullet = " + bullet + " armor = " + armor + " Maneuver = " + Maneuver);
        }

        public static tank operator *(tank T34, tank pantera)
        {
            if (T34.bullet > pantera.bullet && T34.armor > pantera.armor)
            {
                return T34;
            }
            if (T34.bullet > pantera.bullet && T34.Maneuver > pantera.Maneuver)
            {
                return T34;
            }
            if (T34.armor > pantera.armor && T34.Maneuver > pantera.Maneuver)
            {
                return T34;
            }
            else
            {
                return pantera;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            tank[] VIN = new tank[5];
            tank[] T34 = new tank[5];
            for (int i = 0; i < T34.Length; i++)
            {
                VIN[i] = new tank();
            }
            for (int i = 0; i < T34.Length; i++)
            {
                T34[i] = new tank(rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), "T34");
            }
            tank[] pantera = new tank[5];
            for (int i = 0; i < T34.Length; i++)
            {
                pantera[i] = new tank(rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), "pantera");
            }
            for (int i = 0; i < 5; i++)
            {
                T34[i].Print();
                pantera[i].Print(); ;
                VIN[i] = T34[i] * pantera[i];
                Console.WriteLine();
                Console.WriteLine($"В {i + 1} схватке победил");
                VIN[i].Print();
                Console.WriteLine();
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
