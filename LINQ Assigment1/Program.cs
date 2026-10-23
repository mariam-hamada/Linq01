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

            #region Question3
            // 3.Sort all products by UnitPrice(ascending). Print each product's name and price. 
            //var result = Source.ProductList
            //                   .OrderBy(p => p.UnitPrice)
            //                   .Select(p => new { p.ProductName, p.UnitPrice });

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"Product Name: {product.ProductName} , Price: {product.UnitPrice}");
            //}


            #endregion

            #region Question4
            //4. Get all products where UnitPrice is between 10 and 30 
            //var result = Source.ProductList
            //                   .Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30)
            //                   .Select(p => new { p.ProductName, p.UnitPrice });

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"Product Name: {product.ProductName} , Price: {product.UnitPrice}");
            //}

            #endregion

            #region Question5
            //5. Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category. 

            //var result = Source.ProductList
            //                   .Where(p => p.UnitsInStock >0 && p.Category == "Condiments")
            //                   .Select(p => new { p.ProductName, p.UnitsInStock , p.Category });

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"Product Name: {product.ProductName} , Stock: {product.UnitsInStock} , Category: {product.Category}");
            //}

            #endregion

        }
    }
}
