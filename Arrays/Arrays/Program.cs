using System.ComponentModel.DataAnnotations;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, };

            Console.WriteLine("Verilmis ededlerden en boyuku: "+  numbers[numbers.Length - 1]);

            Console.WriteLine("=====================================");

            var product1 = new { Id = 1, Name = "IPhone", Price = 900, StockCount = 5 };
            var product2 = new { Id = 2, Name = "Samsung", Price = 700 , StockCount = 9 };
            var product3 = new { Id = 3, Name = "Honor" , Price = 400 , StockCount = 10 };
            var product4 = new { Id = 4, Name = "Xioami" , Price = 370 , StockCount = 11 };

            var products = new[] { product1, product2, product3, product4 };

            

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Id % 2 != 1)
                    continue;
                else
                    Console.WriteLine(products[i].Id);
                
            }

            int count = 0;
           

            for (int a = 0;a < products.Length; a++)
            {
                count += products[a].Price;

            }

            int sum =  count/products.Length;
            Console.WriteLine($"Qiymetlerin ededi ortasi:{sum}");
            
             
            


        }
    }
}
