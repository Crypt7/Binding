using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding
{
    public class Employee
    {
        public string Name { get; set; }
        public string Title { get; set; }

        public static Employee GetEmploye()
        {
            var emp = new Employee
            {
                Name = "jack",
                Title = "Developer"
            };
            return emp;
        }
    }
}
