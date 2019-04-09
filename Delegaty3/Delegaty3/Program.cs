using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegaty3
{
    public class System
    {
        public delegate void Logi(string wiadomosc);
        private Logi wyslijLogi;
        public void DodajCallback(Logi funkcja)
        {
            wyslijLogi += funkcja;
        }
        public void UsunCallback(Logi funkcja)
        {
            wyslijLogi -= funkcja;
        }
        public bool Logowanie(string user, string password)
        {
            wyslijLogi("Nastąpiła próba logowania użytkownika: " + user);
            return true;
        }
    }


    class Program
    {
        static void CallbackLogi(string wiadomosc)
        {
            Console.WriteLine(wiadomosc);
            Console.WriteLine("Została wywołana funkcja zwrotna");
        }
        static void Main()
        {
            System system = new System();
            system.DodajCallback(CallbackLogi);
            system.Logowanie("user", "pass");
            Console.ReadKey();
        }
    }

}
