namespace InfernoDb.Data.Repository
{
    using System;
    using InfernoDb.Models;
    public interface IUowData : IDisposable
    {

        IRepository<Vendor> Vendors { get; }
        IRepository<Measure> Measures { get; }
        IRepository<Product> Products { get; }


        int SaveChanges();
    }
}
