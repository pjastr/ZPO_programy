using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LancuchZobowiazan
{
    //kod ze strony http://devman.pl/pl/techniki/wzorce-projektowe-lancuch-zobowiazanchain-responsibility/

    class Program
    {
        static void Main(string[] args)
        {
            //Initializing objects
            Number one = new One();
            Number two = new Two();
            Number three = new Three();

            //Setting elements of a one-way list
            one.setNumber(two);
            two.setNumber(three);

            //An example of a set of numbers
            List<TypeNumber> QuestsOnToday = new List<TypeNumber> {
                TypeNumber.One,
                TypeNumber.Two,
                TypeNumber.Three
            };

            //Seek the right number
            foreach (var quest in QuestsOnToday)
            {
                one.ForwardRequest(quest);
            }

            Console.ReadKey();
        }
    }

    abstract class Number
    {
        protected Number number;

        public void setNumber(Number number)
        {
            this.number = number;
        }

        public abstract void ForwardRequest(TypeNumber typenumber);
    }

    public enum TypeNumber
    {
        One,
        Two,
        Three
    }

    class One : Number
    {
        public override void ForwardRequest(TypeNumber typenumber)
        {
            if (typenumber == TypeNumber.One)
            {
                Console.WriteLine("The first request is supported");
            }
            else if (number != null)
            {
                number.ForwardRequest(typenumber);
            }
        }
    }

    class Two : Number
    {
        public override void ForwardRequest(TypeNumber typenumber)
        {
            if (typenumber == TypeNumber.Two)
            {
                Console.WriteLine("The second request is supported");
            }
            else if (number != null)
            {
                number.ForwardRequest(typenumber);
            }
        }
    }

    class Three : Number
    {
        public override void ForwardRequest(TypeNumber typenumber)
        {
            if (typenumber == TypeNumber.Three)
            {
                Console.WriteLine("The third request is supported");
            }
            else if (number != null)
            {
                number.ForwardRequest(typenumber);
            }
        }
    }



}
