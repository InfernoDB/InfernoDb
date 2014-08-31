namespace InfernoDb.Client
{
    using InfernoDb.Data;
    using InfernoDb.Data.Repository;
    using InfernoDb.Models;
    using System;
    using System.Linq;
    
    public class InferniDbMain
    {
        public static void Main()
        {

            UowData data = new UowData();

            Product newProd = new Product();

            newProd.ProductName = "Baba Meca";
            newProd.BasePrice = 123M;

            using (data)
            {
                data.Products.Add(newProd);
            }
        }
    }
}
