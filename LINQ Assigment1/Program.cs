using LINQ_Assigment1.DataSources;
using LINQ_Assigment1.Models;
using System.Drawing;
using System.Security.Cryptography;

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

            #region Question6
            //6. Create a new anonymous type with three properties: ● Name → the product name
            //● Price → the unit price
            //● StockStatus → a string: "Available" if UnitsInStock > 0, otherwise "Out of Stock"
            //● Print the result.

            //var result = Source.ProductList
            //                    .Select(p => new
            //                    {
            //                        Name = p.ProductName,
            //                        Price = p.UnitPrice,
            //                        StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //                    });

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"Product Name: {product.Name} , Price: {product.Price} , Stock Status: {product.StockStatus}");
            //}



            #endregion

            #region Question7
            //7. Print each product's name along with its position (1-based) in the list. Expected format: 1. Chai, 2. Chang, etc. 
            //var result = Source.ProductList
            //                   .Select((p, i) => new { Position = i + 1, p.ProductName });

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"{product.Position}. {product.ProductName}");
            //}

            #endregion

            #region Question8
            //8. Sort ProductList by Category ascending, then within each category, sort by UnitPrice descending. 
            //var result = Source.ProductList
            //                   .OrderBy(p => p.Category)
            //                   .ThenByDescending(p => p.UnitPrice);
            //foreach (var product in result)
            //{
            //    Console.WriteLine($"Category: {product.Category}, Product Name: {product.ProductName}, Price: {product.UnitPrice}");
            //}

            #endregion

            #region Question9
            //9. Get all products from the "Beverages" category, sorted by UnitsInStock descending. Print name and stock. 
            //var result = Source.ProductList
            //                   .Where (p => p.Category == "Beverages")
            //                   .OrderByDescending(p => p.UnitsInStock)
            //                   .Select(p => new { p.ProductName, p.UnitsInStock });

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"Product Name: {product.ProductName} , Stock: {product.UnitsInStock}");
            //}

            #endregion

            #region Question10
            //10. Using QUERY SYNTAX with a compound from clause, list all orders placed in 1997 or later showing CustomerID and OrderDate.
            //var result = from c in Source.CustomerList
            //             from o in c.Orders
            //             where o.OrderDate.Year >=1997 
            //             select new { c.CustomerID, o.OrderDate }
            //;

            //foreach (var order in result)
            //{
            //    Console.WriteLine($"Customer ID: {order.CustomerID} , Order Date: {order.OrderDate}");
            //}


            #endregion

            #region Question11
            //11. Show position number alongside ProductName 
            //var result = Source.ProductList.Select((p,i) => new {position = i+1, p.ProductName });

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"{product.position}. {product.ProductName}");
            //}


            #endregion

        }
    }
}
