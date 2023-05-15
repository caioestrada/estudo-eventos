using C.Estudo.Events.Domain.Entities;
using C.Estudo.Events.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace C.Estudo.Events.Infra.Data.Repositories
{
    public class OrbcoreRepository : IOrbcoreRepository
    {
        private readonly IMongoCollection<Orbcore> _orbcore;

        public OrbcoreRepository(IConfiguration configuration)
        {
            var mongoClient = new MongoClient(Environment.GetEnvironmentVariable("MONGOCONNECTION") ?? configuration.GetSection("MongoSettings").GetSection("Connection").Value);
            _orbcore = mongoClient.GetDatabase(Environment.GetEnvironmentVariable("DATABASENAME") ?? configuration.GetSection("MongoSettings").GetSection("DatabaseName").Value).GetCollection<Orbcore>("Orbcore");
        }

        public Orbcore Add(Orbcore orbcore)
        {
            _orbcore.InsertOne(orbcore);
            return orbcore;
        }

        public List<Orbcore> GetAll()
        {
            return _orbcore.Find(Builders<Orbcore>.Filter.Empty).ToList();
        }

        public void DeleteAll()
        {
            _orbcore.DeleteMany(Builders<Orbcore>.Filter.Empty);
        }
    }
}
