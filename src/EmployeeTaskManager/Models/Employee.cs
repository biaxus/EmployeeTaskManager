using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTaskManager.Models
{
    public class Employee
    {
        public Employee() { }

        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        public ICollection<Task> TaskList { get; set; }
    }
}
