using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaGeneryczna
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerycznaKlasa<string> name = new GenerycznaKlasa<string>();
            name.value = "Hello";
            GenerycznaKlasa<float> version = new GenerycznaKlasa<float>();
            version.value = 5.0f;
            Console.WriteLine(name.value);
            Console.WriteLine(version.value);
            Console.ReadKey();
        }
    }

    public class GenerycznaKlasa<T>
    {
        private T data;
        public T value
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
    }
}
