using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest10._1
{
    class Address
    {
        private int index;

        public int Index
        {
            set { index = value; }
            get { return index; }
        }
        private string country = null;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        private string city = null;
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string street = null;
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        private int house;
        public int House
        {
            get { return house; }
            set { house = value; }
        }

        private int apartment;

        public int Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = 123;
            address.Country = "Россия";
            address.City = "Воркута";
            address.Street = "Ленина";
            address.House = 26;
            address.Apartment = 19;
            Console.WriteLine($"Почтовый индекс: " + address.Index);
            Console.WriteLine($"Страна: " + address.Country);
            Console.WriteLine($"Город: " + address.City);
            Console.WriteLine($"Улица: " + address.Street);
            Console.WriteLine($"Дом: " + address.House);
            Console.WriteLine($"Квартира: " + address.Apartment);
            Console.ReadKey();
        }
    }
}
