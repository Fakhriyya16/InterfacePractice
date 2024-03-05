
using Practice_Interface_Services.Models;
using Practice_Interface_Services.Services;

namespace Practice_Interface_Services.Controllers
{
    public class EmployeeController
    {
        EmployeeServices employeeServices;

        public EmployeeController()
        {
            employeeServices = new EmployeeServices();
        }
        public void GetAll()
        {
            var employees = employeeServices.GetAll();

            foreach (var employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name}, Surname: {employee.Surname}, Address: {employee.Address}" +
                    $"Email: {employee.Email}, Age: {employee.Age}, Birthday: {employee.Birthday.ToString("MM-dd-yyyy")}");
            }
        }

        public void GetById()
        {
            int? id = 40;
            var result = employeeServices.GetById(employeeServices.GetAll(),id);
            if(result.ErrorMessage == null)
            {
                Console.WriteLine($"Name: {result.Employee.Name}, Surname: {result.Employee.Surname}, Address: {result.Employee.Address}" +
                    $"Email: {result.Employee.Email}, Age: {result.Employee.Age}, Birthday: {result.Employee.Birthday.ToString("MM-dd-yyyy")}");
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }

        public void Search()
        {
            string nameOrSurname = "Rashad";

            var result = employeeServices.Search(employeeServices.GetAll(),nameOrSurname);

            if(result.ErrorMessage == null)
            {
                Console.WriteLine($"Name: {result.Employee.Name}, Surname: {result.Employee.Surname}, Address: {result.Employee.Address}" +
                    $"Email: {result.Employee.Email}, Age: {result.Employee.Age}, Birthday: {result.Employee.Birthday.ToString("MM-dd-yyyy")}");
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }


        }
    }
}
