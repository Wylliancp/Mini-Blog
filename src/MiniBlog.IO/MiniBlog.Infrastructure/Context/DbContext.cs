﻿using MiniBlog.Domain.Entities;
using MiniBlog.Infrastructure.Model;
using MongoDB.Driver;
using System;

namespace MiniBlog.Infrastructure.Repository
{
    public class DbContext
    {
        public static string ConnectionString { get; set; }
        public static string DatabaseName { get; set; }
        public static bool IsSSL { get; set; }

        private IMongoDatabase _dataBase { get; }
        public DbContext()
        {
            try
            {
                MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(ConnectionString));
                if (IsSSL)
                {
                    settings.SslSettings = new SslSettings { EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12 };
                }
                var mongoClient = new MongoClient(settings);
                _dataBase = mongoClient.GetDatabase(DatabaseName);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar com o servidor.", ex);
            }
        }
        public IMongoCollection<PostModel> Posts
        {
            get
            {
                return _dataBase.GetCollection<PostModel>("post");
            }
        }

        public Tenant Tenant(string host)
        {

            return _dataBase.GetCollection<Tenant>("tenants").Find(x => x.Host.ToLower() == host).FirstOrDefault();

        }
    }
}