

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
        }
    }
}
