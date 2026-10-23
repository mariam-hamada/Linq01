using LINQ_Assigment1.DataSources;
using LINQ_Assigment1.Models;
using System.Drawing;

namespace LINQ_Assigment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            //1. Get all products from the "Seafood" category. Print each product's name and price. 

            //var result = Source.ProductList
            //                   .Where(p => p.Category == "Seafood")
            //                   .Select(p => new { p.ProductName, p.UnitPrice });

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"Product Name: {product.ProductName} , Price: {product.UnitPrice}");
            //}

            #endregion

            #region Question2
            //2. Get a list of only the product names from ProductList. Print each name. 

            //var result = Source.ProductList
            //                   .Select(p => p.ProductName);

            //foreach (var Product in result)
            //{
            //    Console.WriteLine($"Product Name: {Product}");
            //}

            #endregion
        }
    }
}
