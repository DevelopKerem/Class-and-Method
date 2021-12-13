using System;

namespace ClassIntro
{
   public class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Fish";
            product1.Price =50;
            product1.Details = "Big Fish";
            product1.StokAdedi = 20;

            Product product2 = new Product();
            product2.ProductName = "Lemon";
            product2.Price = 5;
            product2.Details = "Medium Lemon";
            product2.StokAdedi = 50;

            Product product3 = new Product();
            product3.ProductName = "Melon";
            product3.Price = 10;
            product3.Details = "Small Melon";
            product3.StokAdedi = 30;

            Product[] products = new Product[] {product1,product2,product3};

            foreach (var prod in products)
            {
                Console.WriteLine(prod.ProductName + " : " + prod.Details);
            }

            Console.WriteLine("-------------------------------------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            sepetManager.Ekle(product3);


            Console.ReadKey();
         

        }
        public class Product
        {
            public string ProductName { get; set; }
            public int  Price { get; set; }
            public string Details { get; set; }
            public int StokAdedi { get; set; }
        }
            
        }
    }
