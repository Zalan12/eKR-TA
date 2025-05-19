using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKRÉTA.Models
{
    public class GenericRepository<T> : IGenericRepository<T> where T : new()
    {
        private readonly string _dbPath;

        public GenericRepository(string dbPath)
        {
            _dbPath = dbPath;
        }

        public List<T> GetAll()
        {
            using var conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<T>();
            return conn.Table<T>().ToList();
        }

        public void Insert(T item)
        {
            using var conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<T>();
            conn.Insert(item);
        }

        public void Update(T item)
        {
            using var conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<T>();
            conn.Update(item);
        }

        public void Delete(T item)
        {
            using var conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<T>();
            conn.Delete(item);
        }
    }
}
