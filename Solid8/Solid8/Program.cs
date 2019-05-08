using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid8
{
    //http://itcraftsman.pl/solidny-jak-solid-pisanie-solidnych-aplikacji-w-jezyku-c/
    class Program
    {
        static void Main(string[] args)
        {
            Weapon _weapon;

            Console.WriteLine("Using random weapon");
            _weapon = new Weapon();
            _weapon.Shoot();

            Console.WriteLine("Using sword");
            _weapon = new Sword();
            _weapon.Shoot();

            Console.WriteLine("Using bow");
            _weapon = new Bow();
            _weapon.Shoot();

            Console.ReadKey();
        }
    }

    class Weapon
    {
        public string Name { get; set; }
        public virtual void Shoot()
        {
            Console.WriteLine("Use Your weapon to shoot or hit");
        }
    }

    class Sword : Weapon
    {
        public override void Shoot()
        {
            base.Shoot();
            Console.WriteLine("Hit hit!");
        }
    }

    class Bow : Weapon
    {
        public override void Shoot()
        {
            base.Shoot();
            Console.WriteLine("Fire aim!");
        }
    }
}
