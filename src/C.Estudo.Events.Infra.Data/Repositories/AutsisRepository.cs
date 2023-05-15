using C.Estudo.Events.Domain.Entities;
using C.Estudo.Events.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace C.Estudo.Events.Infra.Data.Repositories
{
    public class AutsisRepository : IAutsisRepository
    {
        private readonly IMongoCollection<Autsis> _autsis;

        public AutsisRepository(IConfiguration configuration)
        {
            var mongoClient = new MongoClient(Environment.GetEnvironmentVariable("MONGOCONNECTION") ?? configuration.GetSection("MongoSettings").GetSection("Connection").Value);
            _autsis = mongoClient.GetDatabase(Environment.GetEnvironmentVariable("DATABASENAME") ?? configuration.GetSection("MongoSettings").GetSection("DatabaseName").Value).GetCollection<Autsis>("Autsis");
        }

        public Autsis Add(Autsis autsis)
        {
            _autsis.InsertOne(autsis);
            return autsis;
        }

        public List<Autsis> GetAll()
        {
            return _autsis.Find(Builders<Autsis>.Filter.Empty).ToList();
        }

        public void DeleteAll()
        {
            _autsis.DeleteMany(Builders<Autsis>.Filter.Empty);
        }
    }
}
