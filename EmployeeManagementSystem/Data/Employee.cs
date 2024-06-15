using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Data
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary {  get; set; }
        public int Experience { get; set; }
    }
}
