using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //SOLİD'in Open Closed Prensibi-Mevcuttaki hiçbir kod değiştirilmedi. Business iş kodlarımızı değiştirmedik 
            //InMemory mimarisini kullandık.yan bellekte yapıldı. Bu gelecekte Dapper-EntityFramework-NHibernate... olabilir. 

            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
