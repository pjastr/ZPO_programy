using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid10
{
    //http://itcraftsman.pl/solidny-jak-solid-pisanie-solidnych-aplikacji-w-jezyku-c/
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public interface ICallable
    {
        void Call(int number);
    }

    public interface ITextable
    {
        void Text(int number, string textMessage);
    }

    public interface ITransferable
    {
        void TransferFiles(int blueID);
    }

    public interface IConnectable
    {
        void ConnectInternet();
    }

    public interface INavigable
    {
        void UseGPS();
    }

    class OldNokiaPhone : ICallable, ITextable
    {
        public void Call(int number)
        {
            throw new NotImplementedException();
        }

        public void Text(int number, string textMessage)
        {
            throw new NotImplementedException();
        }
    }

    class AppleIPhone : ICallable, ITextable, IConnectable, ITransferable, INavigable
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
