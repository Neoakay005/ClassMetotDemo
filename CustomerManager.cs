using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer musteri)
        {
            Console.WriteLine("Müşteri Id : " + musteri.Id);
            Console.WriteLine("Adı : " + musteri.Name);
            Console.WriteLine("Soyadı : " + musteri.Surname);
            Console.WriteLine("Doğum Yılı : " + musteri.BirthYear);
        }
        public void List(Customer[] musteri)
        {
            foreach (Customer i in musteri)
            {
                Console.WriteLine("Musteri Adı, Soyadı: "+ i.Name + ", " + i.Surname);
            }
        }
        public void Delete(Customer musteri)
        {
            Console.WriteLine("Müşteri silindi: " + musteri.Name + " " + musteri.Surname);
        }
    }
}
