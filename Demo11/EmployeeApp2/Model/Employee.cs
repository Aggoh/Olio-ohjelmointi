using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp2.Model
{
    public class Employee
    {
        public string ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string JobTitle { get; set; }
        public EmployeeImage Image { get; set; }
        public string Fullname
        {
            get
            {
                return Lastname + " " + Firstname;
            }
        }
    }

    public class EmployeeViewModel
    {
        private List<Employee> employees = new List<Employee>();
        public List<Employee> Employees { get { return employees; } }

        public EmployeeViewModel()
        {
            // generate dummy data if needed
        }
    }
}
