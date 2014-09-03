﻿namespace MongoDbData.MongoRepository
{
    using InfernoDb.Models;

    public interface IMongoUow
    {
         IMongoDbRepository<Product> Products { get; }

         IMongoDbRepository<Vendor> Vendors { get; }

         IMongoDbRepository<Measure> Measurs { get; }

    }

}