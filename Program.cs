using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer musteri1 = new Customer();
            musteri1.Id = 1;
            musteri1.Name = "Halil";
            musteri1.Surname = "Akay";
            musteri1.BirthYear = 1987;

            Customer musteri2 = new Customer();
            musteri2.Id = 2;
            musteri2.Name = "Ali";
            musteri2.Surname = "Çalık";
            musteri2.BirthYear = 1965;

            Customer musteri3 = new Customer();
            musteri3.Id = 3;
            musteri3.Name = "Yavuz";
            musteri3.Surname = "Solmaz";
            musteri3.BirthYear = 1982;

            Customer[] musteri = new Customer[] {musteri1,musteri2,musteri3};

            CustomerManager musteriManager = new CustomerManager();
            musteriManager.List(musteri);

            Console.WriteLine("-----------------------------------");
            musteriManager.Add(musteri1);
            Console.WriteLine("-----------------------------------");
            musteriManager.Add(musteri2);
            Console.WriteLine("-----------------------------------");
            musteriManager.Add(musteri3);
            Console.WriteLine("-----------------------------------");
            musteriManager.Delete(musteri1);
            
        }
    }
}
