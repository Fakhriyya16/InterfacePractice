using Practice_Interface_Services.Helpers.Responses;
using Practice_Interface_Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Interface_Services.Services.Interfaces
{
    public interface IEmployeeServices
    {
        Employee[] GetAll();
        EmployeeResponse GetById(Employee[] employees,int? id);

        EmployeeResponse Search(Employee[] employees,string nameOrSurname);
    }
}
