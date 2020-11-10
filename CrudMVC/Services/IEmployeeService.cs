using System;
using System.Collections.Generic;
using CrudMVC.Models;

namespace CrudMVC.Services
{
    public interface IEmployeeService
    {
        Employee Create(Employee employee);
        IList<Employee> Read();
        Employee Find(string id);
        void Update(Employee employee);
        void Delete(string id);
    }
}