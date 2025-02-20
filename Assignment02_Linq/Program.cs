using System;
using System.Linq;
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

            #region 9- Get the total units in stock for each product category.

            //var totalUnitsInStockByCategory = ProductList.GroupBy(product => product.Category).
            //     Select(catproduct => new
            //     {
            //         Category = catproduct.Key,
            //         TotalUnitsInStock = catproduct.Sum(product => product.UnitsInStock)
            //     });
            //foreach (var product in totalUnitsInStockByCategory)
            //    Console.WriteLine(product);

            #endregion

            #region 10- Get the cheapest price among each category's products


            //var cheapestPriceByCategory = ProductList.GroupBy(product => product.Category)
            //    .Select(catproduct => new
            //    {

            //        Category = catproduct.Key,
            //        CheapestPrice = catproduct.Min(product => product.UnitPrice)
            //    });

            //foreach (var catproduct in cheapestPriceByCategory)
            //    Console.WriteLine(catproduct);

            #endregion

            #region 11- Get the products with the cheapest price in each category (Use Let)

            //var cheapestPriceByCategory = from product in ProductList
            //                              group product by product.Category into productGroup
            //                              let minPrice = productGroup.Min(product => product.UnitPrice)
            //                              from product in productGroup
            //                              where product.UnitPrice == minPrice
            //                              select new
            //                              {
            //                                  Category = product.Category,
            //                                  ProductName = product.ProductName,
            //                                  Price = product.UnitPrice
            //                              };

            //foreach (var catproduct in cheapestPriceByCategory)
            //    Console.WriteLine(catproduct);

            #endregion

            #region 12- Get the most expensive price among each category's products.

            //var mostExpensivePriceByCategory = ProductList.GroupBy(product => product.Category)
            //        .Select(catproduct => new
            //        {

            //            Category = catproduct.Key,
            //            MaxPrice = catproduct.Max(product => product.UnitPrice)
            //        });

            //foreach (var catproduct in mostExpensivePriceByCategory)
            //    Console.WriteLine(catproduct);

            #endregion

            #region 13- Get the products with the most expensive price in each category.

            //var mostExpensivePriceByCategory = ProductList.GroupBy(product => product.Category)
            //        .Select(catproduct => new
            //        {

            //            Category = catproduct.Key,
            //            MaxPrice = catproduct.Max(product => product.UnitPrice)
            //        });

            //foreach (var catproduct in mostExpensivePriceByCategory)
            //    Console.WriteLine(catproduct);

            #endregion

            #region 14- Get the average price of each category's products.

            //var averagePriceByCategory = ProductList.GroupBy(product => product.Category)
            //       .Select(catproduct => new
            //       {

            //           Category = catproduct.Key,
            //           AveragePrice = catproduct.Average(product => product.UnitPrice)
            //       });

            //foreach (var catproduct in averagePriceByCategory)
            //    Console.WriteLine(catproduct);

            #endregion


            #endregion

            #region LINQ - Set Operators

            #region 1- Find the unique Category names from Product List

            //var Product = ProductList.Select(product => product.Category).Distinct();
            //foreach (var item in Product) 
            //    Console.WriteLine(item); 
            #endregion

            #region 2- Produce a Sequence containing the unique first letter from both product and customer names.


            //var uniqueFirstLetters = ProductList
            //                      .Select(product => product.ProductName).First()
            //                          .Union(CustomerList.Select(Customer => Customer.CustomerName.First()))
            //                            .Distinct().OrderBy(c => c);

            //foreach (var product in uniqueFirstLetters)
            //    Console.WriteLine(product); 
            #endregion


            #region 3- Create one sequence that contains the common first letter from both product and customer names.
            //var commonFirstLetters = ProductList
            //                      .Select(product => product.ProductName).First()
            //                          .Intersect(CustomerList.Select(Customer => Customer.CustomerName.First()))
            //                            .OrderBy(c => c);

            //foreach (var product in commonFirstLetters)
            //    Console.WriteLine(product);

            #endregion

            #region 4- Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var Product = ProductList
            //                      .Select(product => product.ProductName).First()
            //                          .Except(CustomerList.Select(Customer => Customer.CustomerName.First()))
            //                            .OrderBy(c => c);

            //foreach (var product in Product)
            //    Console.WriteLine(product);

            #endregion

            #region 5- Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates


            //var Product = ProductList.Select(product => product.ProductName.Length >3 )
            //                          .Concat(CustomerList.Select(Customer => Customer.CustomerName.Length > 3 ))
            //                        ;

            //foreach (var product in Product)
            //    Console.WriteLine(product);

            #endregion

            #endregion

            #region LINQ - Quantifiers


            #region 1- Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.Any(word => word.Contains("ei"));
            //Console.WriteLine(result);

            #endregion

            #region 2- Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //var categoriesWithOutOfStockProducts = ProductList
            //                             .GroupBy(product => product.Category)
            //                             .Where(products => products.Any(product => product.UnitsInStock == 0)).
            //                             Select(product => new { Category = product.Key, Products = product.ToList() });

            //foreach (var category in categoriesWithOutOfStockProducts)
            //    Console.WriteLine(category);

            #endregion

            #region 3- Return a grouped a list of products only for categories that have all of their products in stock.


            //var Product = ProductList.GroupBy(product => product.Category)
            //     .Where(group => group.All(product => product.UnitsInStock > 0))
            // .Select(group => new { Category = group.Key, Products = group.ToList() });

            // foreach (var product in Product) 
            //     Console.WriteLine(product);
        }
        #endregion

        #endregion
    }

}
