//using Microsoft.Data.Sqlite;
//using System;
//using Microsoft.EntityFrameworkCore;
//using System.IO;

//namespace Test
//{
//    internal class DbCopy
//    {
//        public string DbPath { get; private set; } = string.Empty;

//        public SQLiteConnection CreateInMemoryDatabase(string existingDatabaseFilePath)
//        {
//            // Set the path to the existing database
//            var folder = Environment.SpecialFolder.MyDocuments;
//            var path = Environment.GetFolderPath(folder);
//            DbPath = Path.Join(path, "ThAmCo.catering.db");

//            // Open a connection to the existing database
//            using var sourceConnection = new SQLiteConnection($"Data Source={existingDatabaseFilePath};");
//            sourceConnection.Open();

//            // Create an in-memory database connection
//            var inMemoryConnection = new SQLiteConnection("Data Source=:memory:;");
//            inMemoryConnection.Open();

//            // Copy the source database to the in-memory database
//            sourceConnection.BackupDatabase(inMemoryConnection, "main", "main", -1, null, 0);

//            return inMemoryConnection;
//        }
//    }
//}

