using System;
using static Assignment02_Linq.ListGenerator;
namespace Assignment02_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LINQ - Element Operators


            #region 1- Get first Product out of Stock

            //var Product = ProductList.FirstOrDefault(product => product.UnitsInStock == 0);

            ////var Product = (from product in ProductList
            ////              where product.UnitsInStock == 0
            ////              select product).FirstOrDefault();

            //Console.WriteLine(Product);

            #endregion

            #region 2- Return the first product whose Price > 1000, unless there is no match, in which 

            //var Product = ProductList.FirstOrDefault(product => product.UnitPrice > 1000);

            //Console.WriteLine(Product);


            #endregion

            #region 3- Retrieve the second number greater than 5
            //int[] arr = {5, 4, 1, 3, 9, 8, 6, 7, 2,0 };

            //var result = arr.Where(n => n > 5).ElementAtOrDefault(1) ;

            //Console.WriteLine(result); 
            #endregion

            #endregion



            #region LINQ - Aggregate Operators

            #region 1- Uses Count to get the number of odd numbers in the array

            //int[] Number = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Number.Count(number => number % 2 !=0 );
            //Console.WriteLine(result);

            #endregion


            #region 2- Return a list of customers and how many orders each has

            //var Customers = CustomerList.Select(customers => new {

            //    CustomerName = customers,

            //    OrderCount = customers.Orders.Count()


            //});

            //foreach(var customer in Customers) 
            //     Console.WriteLine(customer);


            #endregion

            #region 3- Return a list of categories and how many products each has

            //var ListOfCategories = ProductList.GroupBy(product => product.Category).
            //                                    Select(catproduct => new
            //                                    {
            //                                        Category = catproduct.Key,

            //                                        ProductCount = catproduct.Count()

            //                                    });

            //foreach (var Category in ListOfCategories) 
            //    Console.WriteLine(Category);


            #endregion

            #region 4- Get the total of the numbers in an array.

            //int[] Number = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Number.Sum();

            //Console.WriteLine(result);

            #endregion

            #region From 5 To 8  dictionary_english.txt

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var totalCharacters = words.Sum(word => word.Length);

            //Console.WriteLine(totalCharacters);



            //var shortestWordLength = words.Min(word => word.Length);

            //Console.WriteLine(shortestWordLength);


            //var longesttWordLength = words.Max(word => word.Length);
            //Console.WriteLine(longesttWordLength);

            //var averageLength = words.Average(word => word.Length);

            //Console.WriteLine(averageLength); 
            #endregion



            #endregion
        }
    }
}
