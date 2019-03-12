using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterWzorzecProjektowy
{
    // kod pochodzi ze strony http://www.altcontroldelete.pl/artykuly/wzorzec-adapter-przykladowa-implementacja-w-c/

    class Program
    {
        static void Main(string[] args)
        {
            SomeStrangeClass obj = new SomeStrangeClass();
            IListener listener = new SomeStrangeClassAdapter(obj);
            listener.Notify("Testowa wiadomość!!!");
            Console.ReadKey();
        }
    }


    public class SomeStrangeClass
    {
        public void DoSomeStrangeThing(string info)
        {
            Console.WriteLine(info);
        }
    }

    public interface IListener
    {
        void Notify(string msg);
    }

    public class SomeStrangeClassAdapter : IListener
    {
        private SomeStrangeClass adaptee = null;

        public SomeStrangeClassAdapter(SomeStrangeClass adaptee)
        {
            this.adaptee = adaptee;
        }

        public void Notify(string msg)
        {
            // Optionally - do something else
            this.adaptee.DoSomeStrangeThing(msg);
        }
    }
}
