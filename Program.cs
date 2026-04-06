

using G_Net_40_LINQ01.Models;
using G_Net_40_LINQ01.DataSources;
namespace G_Net_40_LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //    var productList = Source.ProductList;

            //    var seafoodProducts = productList
            //        .Where(p => p.Category == "Seafood")
            //        .Select(p => new
            //        {
            //            p.ProductName,
            //            Price = p.UnitPrice
            //        });

            //    foreach (var product in seafoodProducts)
            //    {
            //        Console.WriteLine($"{product.ProductName} - {product.Price}");
            //    }
            #endregion
            #region Question 2
            //var productlist = Source.ProductList;
            //var productNames = productlist.Select(p => p.ProductName);

            //foreach (var name in productNames)
            //{
            //    Console.WriteLine($"Product name {name}");
            //}
            #endregion
            #region Question 3
            //var productlist3 = Source.ProductList.OrderByDescending(p => p.UnitPrice);
            //foreach (var i in productlist3)
            //{
            //    Console.WriteLine($"Name {i.ProductName} price {i.UnitPrice}");
            //}
            #endregion
            #region Question 4
            //var productlist4 = Source.ProductList.Where(p => p.UnitPrice > 10 && p.UnitPrice < 30);
            //foreach (var product in productlist4)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion
            #region Question 5
            //var productlist = Source.ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");
            //foreach (var product in productlist)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion
            #region Question 6
            //var productlist = Source.ProductList.Select(p => new
            //{
            //    name = p.ProductName,
            //    price = p.UnitPrice,
            //    stockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //});
            //foreach (var product in productlist)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion
            #region Question 7
            //var productlist = Source.ProductList.Select((p, index) => (index + 1, p.ProductName));

            //foreach (var product in productlist)
            //{
            //    Console.WriteLine($"{product.Item1}. {product.Item2}");
            //}
            #endregion
            #region Question 8
            //var productlist = Source.ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var product in productlist)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion
            #region Question 9
            //var productlist = Source.ProductList.Where(p => p.Category == "Beverages").OrderByDescending(p => p.UnitsInStock);
            //foreach (var product in productlist)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion
        }
    }
}
