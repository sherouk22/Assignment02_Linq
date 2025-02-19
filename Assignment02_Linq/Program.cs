using System;
using static Assignment02_Linq.ListGenerator;
namespace Assignment02_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LINQ - Element Operators



            //var Product = ProductList.FirstOrDefault(product => product.UnitsInStock == 0);

            ////var Product = (from product in ProductList
            ////              where product.UnitsInStock == 0
            ////              select product).FirstOrDefault();

            //Console.WriteLine(Product);



            //var Product = ProductList.FirstOrDefault(product => product.UnitPrice > 1000);

            //Console.WriteLine(Product);



            //int[] arr = {5, 4, 1, 3, 9, 8, 6, 7, 2,0 };

            //var result = arr.Where(n => n > 5).ElementAtOrDefault(1) ;

            //Console.WriteLine(result);

            #endregion


            //int[] Number = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Number.Count(number => number % 2 !=0 );
            //Console.WriteLine(result);




            //var Customers = CustomerList.Select(customers => new {

            //    CustomerName = customers,

            //    OrderCount = customers.Orders.Count()


            //});

            //foreach(var customer in Customers) 
            //     Console.WriteLine(customer);



            //var ListOfCategories = ProductList.GroupBy(product => product.Category).
            //                                    Select(catproduct => new
            //                                    {
            //                                        Category = catproduct.Key,

            //                                        ProductCount = catproduct.Count()

            //                                    });

            //foreach (var Category in ListOfCategories) 
            //    Console.WriteLine(Category);



            //int[] Number = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Number.Sum();

            //Console.WriteLine(result);



            string[] words = File.ReadAllLines("dictionary_english.txt");

            var totalCharacters = words.Sum(word => word.Length);

            Console.WriteLine(totalCharacters);



            var shortestWordLength = words.Min(word => word.Length);

            Console.WriteLine(shortestWordLength);


            var longesttWordLength = words.Max(word => word.Length);
            Console.WriteLine(longesttWordLength);

            var averageLength = words.Average(word => word.Length);

            Console.WriteLine(averageLength);

        }
    }
}
