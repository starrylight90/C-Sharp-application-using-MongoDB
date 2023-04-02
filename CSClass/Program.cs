using System;
using MongoDB.Driver;

using com.hr; // Needed for Employee

namespace listlinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            vr db = client.GetDatabase("hr");
            var colletion = db.GetCollection<Employee>("emp");
            Console.WriteLine("Hello World");
        }
    }
}

