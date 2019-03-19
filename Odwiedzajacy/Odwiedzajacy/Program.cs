using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odwiedzajacy
{
    //kod ze strony http://devman.pl/pl/techniki/wzorce/wzorce-projektowe-odwiedzajacyvisitor/

    class Program
    {
        static void Main(string[] args)
        {
            ObjectStructure o = new ObjectStructure();
            o.Attach(new ElementA());
            o.Attach(new ElementB());

            Visitor v1 = new Visitor1();
            Visitor v2 = new Visitor2();

            o.Accept(v1);
            o.Accept(v2);

            Console.ReadKey();
        }
    }

    abstract class Visitor
    {
        public abstract void VisitElement(
          ElementA elementA);
        public abstract void VisitElement(
          ElementB elementB);
    }

    class Visitor1 : Visitor
    {
        public override void VisitElement(
          ElementA elementA)
        {
            Console.WriteLine(elementA.GetType().Name + " visited by " + GetType().Name);
        }

        public override void VisitElement(
          ElementB elementB)
        {
            Console.WriteLine(elementB.GetType().Name + " visited by " + GetType().Name);
        }
    }

    class Visitor2 : Visitor
    {
        public override void VisitElement(
          ElementA elementA)
        {
            Console.WriteLine(elementA.GetType().Name + " visited by " + GetType().Name);
        }

        public override void VisitElement(
          ElementB elementB)
        {
            Console.WriteLine(elementB.GetType().Name + " visited by " + GetType().Name);
        }
    }

    abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }


    class ElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitElement(this);
        }
    }

    class ElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitElement(this);
        }
    }

    class ObjectStructure
    {
        private List<Element> _elements = new List<Element>();

        public void Attach(Element element)
        {
            _elements.Add(element);
        }

        public void Detach(Element element)
        {
            _elements.Remove(element);
        }

        public void Accept(Visitor visitor)
        {
            foreach (Element element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
