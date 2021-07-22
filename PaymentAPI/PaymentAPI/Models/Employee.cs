using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public class Employee
    {
        [Key] public int EmployeeId { get; set; }
        [MaxLength(500)] public string EmployeeName { get; set; }
        [MaxLength(500)] public string Department { get; set; }
        public DateTime DateOfJoining { get; set; }
        [MaxLength(500)] public string PhotoFileName { get; set; }

    }
}
