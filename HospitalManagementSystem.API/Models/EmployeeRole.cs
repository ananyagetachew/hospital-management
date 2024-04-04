using HospitalManagementSystem.API.Models.Base;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HospitalManagementSystem.API.Models
{
    public class EmployeeRole : BaseModel
    {
        public string Permission { get; set; }
        public ICollection<Employee> Employees { get; set; }


        public EmployeeRole()
        {
            Employees = new Collection<Employee>();
        }
    }
}
