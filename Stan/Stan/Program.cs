using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stan
{
    class Program
    {
        //kod ze strony http://devman.pl/pl/techniki/wzorce-projektowe-stanstate/

        static void Main(string[] args)
        {
            Context c = new Context();
            c.setState(new StateOne());

            c.Request();
            c.Request();
            c.Request();
            c.Request();
            c.Request();

            Console.ReadKey();
        }
    }

    class Context
    {
        private State current;

        public void setState(State state)
        {
            current = state;
            Console.WriteLine("State: " + current.GetType().Name);
        }

        public void Request()
        {
            current.goNext(this);
        }
    }

    abstract class State
    {
        public abstract void goNext(Context context);
    }

    class StateOne : State
    {
        public override void goNext(Context context)
        {
            context.setState(new StateTwo());
        }
    }

    class StateTwo : State
    {
        public override void goNext(Context context)
        {
            context.setState(new StateThree());
        }
    }

    class StateThree : State
    {
        public override void goNext(Context context)
        {
            context.setState(new StateOne());
        }
    }
}
