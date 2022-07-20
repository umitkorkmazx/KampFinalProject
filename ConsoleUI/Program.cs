using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //open closed principle ** yaptığın yazılıma yeni bir özellik ekliyorsan
    // mevucttaki hiç bir koduna dokunamazsın
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetByUnitPrice(20,46))
            {
                Console.WriteLine(product.ProductName + "---=>" + product.UnitPrice);
            }
        }
    }
}
