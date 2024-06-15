using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Data
{
    public class Flight
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
    }
}
