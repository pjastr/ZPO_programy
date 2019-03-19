using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polecenie
{
    //kod ze strony http://devman.pl/pl/techniki/wzorce/wzorce-projektowe-poleceniecommand/

    class Program
    {
        static void Main(string[] args)
        {
            string argument = null;

            ISwitchable lamp = new Light();

            ICommand switchClose = new CloseSwitchCommand(lamp);
            ICommand switchOpen = new OpenSwitchCommand(lamp);

            Switch @switch = new Switch(switchClose, switchOpen);

            while (!string.IsNullOrEmpty(argument = Console.ReadLine()))
            {
                if (argument == "ON")
                {
                    @switch.Open();
                }
                else if (argument == "OFF")
                {
                    @switch.Close();
                }
                else
                {
                    Console.WriteLine("Argument \"ON\" or \"OFF\" is required.");
                }
            }

            Console.ReadKey();
        }
    }

    public interface ICommand
    {
        void Execute();
    }

    public class CloseSwitchCommand : ICommand
    {
        private ISwitchable _switchable;

        public CloseSwitchCommand(ISwitchable switchable)
        {
            _switchable = switchable;
        }

        public void Execute()
        {
            _switchable.PowerOff();
        }
    }

    public class OpenSwitchCommand : ICommand
    {
        private ISwitchable _switchable;

        public OpenSwitchCommand(ISwitchable switchable)
        {
            _switchable = switchable;
        }

        public void Execute()
        {
            _switchable.PowerOn();
        }
    }

    public interface ISwitchable
    {
        void PowerOn();
        void PowerOff();
    }

    public class Switch
    {
        ICommand _closedCommand;
        ICommand _openedCommand;

        public Switch(ICommand closedCommand, ICommand openedCommand)
        {
            _closedCommand = closedCommand;
            _openedCommand = openedCommand;
        }

        public void Close()
        {
            _closedCommand.Execute();
        }

        public void Open()
        {
            _openedCommand.Execute();
        }
    }

    public class Light : ISwitchable
    {
        bool LightState = false;

        public void PowerOn()
        {
            CheckState(true, "The light is already turned on!", "The light is on");
        }

        public void PowerOff()
        {
            CheckState(false, "The light is already turned off!", "The light is off");
        }

        public void CheckState(bool state, string execption, string notification)
        {
            if (LightState == state)
            {
                Console.WriteLine(execption);
            }
            else
            {
                Console.WriteLine(notification);
                LightState = state;
            }
        }
    }
}
