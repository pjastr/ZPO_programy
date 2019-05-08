using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DRY
{
    //kod ze strony http://itcraftsman.pl/uzyteczne-koncepty-projektowe-kiss-dry-yagni-tda-oraz-separation-of-concerns/
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    //zły przyklad
    public class Hamster
    {
        public string HamsterName { get; set; }
        public int HamsterPhoneNumber { get; set; }

        public ICollection<Hamster> HamstersWorld { get; set; }
        public ICollection<Hamster> HamstersHouse { get; set; }

        public void AddHamsterWithSpecificPhoneNumber(Hamster _hamster)
        {
            var getHamsterByPhone = HamstersWorld.ToList().Where(n => n.HamsterPhoneNumber == _hamster.HamsterPhoneNumber).Single();

            HamstersHouse.Add(getHamsterByPhone);
        }

        public void RemoveHamsterWithSpecificPhoneNumber(Hamster _hamster)
        {
            var getHamsterByPhone = HamstersWorld.ToList().Where(n => n.HamsterPhoneNumber == _hamster.HamsterPhoneNumber).Single();

            HamstersHouse.Remove(getHamsterByPhone);
        }
    }

    //dobry przyklad
    public class HamsterGood
    {
        public string HamsterName { get; set; }
        public int HamsterPhoneNumber { get; set; }

        public ICollection<HamsterGood> HamstersWorld { get; set; }
        public ICollection<HamsterGood> HamstersHouse { get; set; }

        public void AddHamsterWithSpecificPhoneNumber(HamsterGood _hamster)
        {
            HamstersHouse.Add(FindHamsterByPhone(_hamster.HamsterPhoneNumber));
        }

        public void RemoveHamsterWithSpecificPhoneNumber(HamsterGood _hamster)
        {
            HamstersHouse.Remove(FindHamsterByPhone(_hamster.HamsterPhoneNumber));
        }

        public HamsterGood FindHamsterByPhone(int phone)
        {
            return HamstersWorld.ToList().Where(n => n.HamsterPhoneNumber == phone).Single();
        }
    }
}
