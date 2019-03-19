/****************************************
*   Wzorzec Projektowy Observer         *
*   (obserwator)                        *  
*   www.algorytm.org                    *
*   Opracowal Dworak Kamil              *
*****************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obserwator
{
    class Program
    {
        static void Main(string[] args)
        {
            TotoLotek totoLotek = new TotoLotek();
            Telewizja telewizja = new Telewizja(totoLotek);
            Internet internet = new Internet(totoLotek);

            totoLotek.dodajObserwatora(telewizja);
            totoLotek.dodajObserwatora(internet);

            totoLotek.kolejneLosowanie();
            Console.WriteLine("LOSOWANIE 1\n");
            telewizja.informuj();
            internet.informuj();

            totoLotek.kolejneLosowanie();
            Console.WriteLine("\nLOSOWANIE 2\n");
            telewizja.informuj();
            internet.informuj();

            /* telewizja juz nie obserwuuje wynikow, nie bedzie miec aktualnych losowan */
            telewizja.spadam();
            totoLotek.kolejneLosowanie();
            Console.WriteLine("\nLOSOWANIE 3\n");
            telewizja.informuj();
            internet.informuj();
            String s = Console.ReadLine();
        }
    }

    interface Obserwowany
    {
        void dodajObserwatora(Obserwator o);
        void usunObserwatora(Obserwator o);
        void powiadamiajObserwatorow();
    }


    interface Obserwator
    {
        /* aktualizuje dane */
        void update(int[] wyniki);
    }


    interface Media
    {
        /* publikuje wyniki losowania */
        void informuj();
    }



    /* oberwowany obiekt */
    class TotoLotek : Obserwowany
    {
        private ArrayList obserwatorzy;
        private int[] wyniki;

        public TotoLotek()
        {
            obserwatorzy = new ArrayList();
            wyniki = new int[] { 0, 0, 0, 0, 0, 0 };
        }

        public void dodajObserwatora(Obserwator o)
        {
            obserwatorzy.Add(o);
        }

        public void usunObserwatora(Obserwator o)
        {
            int index = obserwatorzy.IndexOf(o);
            obserwatorzy.RemoveAt(index);
        }

        public void powiadamiajObserwatorow()
        {
            Obserwator[] tab = (Obserwator[])obserwatorzy.ToArray(typeof(Obserwator));
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i].update(wyniki);
            }
        }

        public void kolejneLosowanie()
        {
            int i = 0;
            Random random = new Random();
            while (i < 6)
            {
                bool powtorka = false;
                int x = random.Next(48);// (Math.random() * 47 - 1);
                for (int j = 0; j < 6; j++)
                {
                    if (wyniki[j] == x)
                    {
                        powtorka = true;
                    }
                }
                if (powtorka == false)
                {
                    wyniki[i++] = x;
                }
            }//while
            powiadamiajObserwatorow();
        }

        public int[] getResults()
        {
            return wyniki;
        }
    }//class

    /* obserwator */
    class Telewizja : Obserwator, Media
    {
        private int[] wyniki;
        private TotoLotek lotek;

        public Telewizja(TotoLotek lotek)
        {
            wyniki = new int[6];
            this.lotek = lotek;
        }

        public void update(int[] tab)
        {
            for (int i = 0; i < 6; i++)
            {
                wyniki[i] = tab[i];
            }
        }

        public void informuj()
        {
            Console.WriteLine("Dzisiejsze losowanie Totolotka by TVP");
            for (int i = 0; i < 6; i++)
                Console.Write(wyniki[i] + " ");
            Console.WriteLine();
        }

        public void spadam()
        {
            lotek.usunObserwatora(this);
        }
    }

    class Internet : Obserwator, Media
    {
        private int[] wyniki;
        private TotoLotek lotek;

        public Internet(TotoLotek lotek)
        {
            wyniki = new int[6];
            this.lotek = lotek;
        }

        public void update(int[] tab)
        {
            for (int i = 0; i < 6; i++)
            {
                wyniki[i] = tab[i];
            }
        }

        public void informuj()
        {
            Console.WriteLine("Wyniki TotoLotka na stronie internetowej");
            for (int i = 0; i < 6; i++)
                Console.Write(wyniki[i] + " ");
            Console.WriteLine();
        }

        public void spadam()
        {
            lotek.usunObserwatora(this);
        }
    }
}
