
using System;
using System.Collections.Generic;
using System.Text;
using Plugin.NetStandardStorage.Abstractions.Interfaces;
using Plugin.NetStandardStorage.Implementations;
using SQLite;
using System.IO;
using SampleAppKelasB.Models;

namespace SampleAppKelasB.DAL
{
    public class DataAccess
    {
        private SQLiteConnection db;
        private SQLiteConnection GetConnection()
        {
            var sqlliteFileName = "Mydb.db3";
            IFolder folder = new FileSystem().LocalStorage;
            string path = Path.Combine(folder.FullPath, sqlliteFileName);
            return new SQLiteConnection(path);
        }
        public DataAccess()
        {
            db = GetConnection();
            db.CreateTable<Employee>();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            string strSql = @"select * from Employee order by EmpName";
            return db.Query<Employee>(strSql);
        }

        public int InsertEmployee(Employee employee)
        {
            try
            {
                return db.Insert(employee);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error {ex.Message}");
            }
        }

        public int DeleteEmployee(Employee employee)
        {
            try
            {
                return db.Delete(employee);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }
    }
}
