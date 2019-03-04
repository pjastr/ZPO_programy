using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Budowniczy
{
    class Program
    {
        static void Main(string[] args)
        {
            var szef = new Dyrektor();
            Budowniczy budowniczy1 = new DomJednorodzinny();
            Budowniczy budowniczy2 = new Biurowiec();

            szef.WybierzBudowniczego(budowniczy1);
            szef.Buduj();
            Budynek budynek1 = szef.PobierzBudynek();
            szef.WybierzBudowniczego(budowniczy2);
            szef.Buduj();
            Budynek budynek2 = szef.PobierzBudynek();
            Console.WriteLine("Pierwsza budowla");
            budynek1.OpiszBudynek();
            Console.WriteLine("Druga budowla");
            budynek2.OpiszBudynek();
            Console.ReadKey();
        }
    }

    public class Budynek
    {
        private string okno;
        private string drzwi;
        private string kolorElewacji;
        public void WstawOkna(string okno)
        {
            this.okno = okno;
        }
        public void ZamontujDrzwi(string drzwi)
        {
            this.drzwi = drzwi;
        }
        public void PomalujElewacje(string elewacja)
        {
            kolorElewacji = elewacja;
        }
        public void OpiszBudynek()
        {
            if (!string.IsNullOrEmpty(okno))
            {
                Console.WriteLine("Okna: " + okno);
            }
            if (!string.IsNullOrEmpty(drzwi))
            {
                Console.WriteLine("Drzwi: " + drzwi);
            }
            if (!string.IsNullOrEmpty(kolorElewacji))
            {
                Console.WriteLine("Elewacja: " + kolorElewacji);
            }
        }
    }
    public abstract class Budowniczy
    {
        protected Budynek Budowla;
        public void NowyBudynek()
        {
            Budowla = new Budynek();
        }
        public Budynek PobierzBudynek()
        {
            return Budowla;
        }
        public abstract void WstawOkna();
        public abstract void ZamontujDrzwi();
        public abstract void PomalujElewacje();
    }

    class DomJednorodzinny : Budowniczy
    {
        public override void WstawOkna()
        {
            Budowla.WstawOkna("Drewniane - złoty dąb");
        }
        public override void ZamontujDrzwi()
        {
            Budowla.ZamontujDrzwi("Antywłamaniowe z wizjerem");
        }
        public override void PomalujElewacje()
        {
            Budowla.PomalujElewacje("Żółta");
        }
    }

    public class Biurowiec : Budowniczy
    {
        public override void WstawOkna()
        {
            Budowla.WstawOkna("Antracytowe nieotwieralne");
        }
        public override void ZamontujDrzwi()
        {
            Budowla.ZamontujDrzwi("Obrotowe lewoskrętne");
        }
        public override void PomalujElewacje()
        {
            // elewacja będzie szklana
        }
    }
    class Dyrektor
    {
        private Budowniczy budowniczy;
        public void WybierzBudowniczego(Budowniczy budowniczy)
        {
            this.budowniczy = budowniczy;
        }
        public Budynek PobierzBudynek()
        {
            return budowniczy.PobierzBudynek();
        }
        public void Buduj()
        {
            budowniczy.NowyBudynek();
            budowniczy.WstawOkna();
            budowniczy.ZamontujDrzwi();
            budowniczy.PomalujElewacje();
        }
    }
}
