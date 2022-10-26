using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ammo_system
{
    internal class Program
    {
        static int[] ammo = { 10, 20, 20, 32 };
        static string[] weapon = {"pistol", "rifle", "shotgun", "152mm howitzer"};
        static void Main(string[] args)
        {
            // Showing third Weapon and its ammo through writeline
            Console.WriteLine(weapon[0] + " " + ammo[0]);
            Console.WriteLine(weapon[1] + " " + ammo[1]);
            Console.WriteLine(weapon[2] + " " + ammo[2]);
            Console.WriteLine(weapon[3] + " " + ammo[3]);
            Console.WriteLine("");

            Fire();
            Console.WriteLine(weapon[2] + " " + ammo[2]);
            Fire();
            Console.WriteLine(weapon[2] + " " + ammo[2]);
            Fire();
            Console.WriteLine(weapon[2] + " " + ammo[2]);
            Fire();
            Console.WriteLine(weapon[2] + " " + ammo[2]);
            Reload();
            Console.WriteLine(weapon[2] + " " + ammo[2]);

            Console.WriteLine("");
            Console.WriteLine(weapon[0] + " " + ammo[0]);
            Console.WriteLine(weapon[1] + " " + ammo[1]);
            Console.WriteLine(weapon[2] + " " + ammo[2]);
            Console.WriteLine(weapon[3] + " " + ammo[3]);
            Console.ReadKey(true);
        }

        static void Fire()
        {
            ammo[2] -= 1;

        }
        static void Reload()
        {
            ammo[2] += 1;
        }
    }
}
