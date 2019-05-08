using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid9
{
    //http://itcraftsman.pl/solidny-jak-solid-pisanie-solidnych-aplikacji-w-jezyku-c/
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public interface IPhone
    {
        void Call(int number);
        void Text(int number, string textMessage);
        void TransferFiles(int blueID);
        void ConnectInternet();
        void UseGPS();
    }

    class Phone : IPhone
    {
        public void Call(int number)
        {
            throw new NotImplementedException();
        }

        public void ConnectInternet()
        {
            throw new NotImplementedException();
        }

        public void Text(int number, string textMessage)
        {
            throw new NotImplementedException();
        }

        public void TransferFiles(int blueID)
        {
            throw new NotImplementedException();
        }

        public void UseGPS()
        {
            throw new NotImplementedException();
        }
    }
}
