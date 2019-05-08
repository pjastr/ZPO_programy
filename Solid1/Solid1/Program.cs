using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Solid1
{
    //kod ze strony http://itcraftsman.pl/solidny-jak-solid-pisanie-solidnych-aplikacji-w-jezyku-c/
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public uint Quantity { get; set; }
        public decimal Price { get; set; }
        public IList<Product> Products { get; set; }
        public Product()
        {
            Products = new List<Product>();
        }

        // Dodaj nowy produkt
        public void AddProduct(Product _prod)
        {
            Products.Add(_prod);
        }

        // Usun produkt
        public void RemoveProduct(Product _prod)
        {
            Products.Remove(_prod);
        }

        // Znajdz produkt po jego ID
        public Product FindProductByID(int _prodID)
        {
            return Products.Where(n => n.ID == _prodID).Single();
        }

        // Zapisz informacje do error loga
        public void CreateErrorLog(string path, string exeption)
        {
            File.WriteAllText(path, exeption);
        }
    }
}
