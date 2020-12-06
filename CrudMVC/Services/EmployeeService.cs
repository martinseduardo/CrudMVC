using System;
using System.Collections.Generic;
using CrudMVC.Models;
using MongoDB.Driver;
using Newtonsoft.Json;

namespace CrudMVC.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IMongoCollection<Employee> _employees;
        
        public EmployeeService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var dataBase = client.GetDatabase(settings.DatabaseName);
            _employees = dataBase.GetCollection<Employee>("Employees");
        }

        public Employee Create(Employee employee)
        {
            var jsonEmployee = JsonConvert.SerializeObject(employee);
            _employees.InsertOne(employee);
            return employee;
        }

        public IList<Employee> Read() =>
            _employees.Find(x => true).ToList();

        public Employee Find(string id) =>
            _employees.Find(x => x.Id == id).SingleOrDefault();

        public void Update(Employee employee) =>
            _employees.ReplaceOne(x => x.Id == employee.Id, employee);

        public void Delete(string id) =>
            _employees.DeleteOne(x => x.Id == id);
    }
}