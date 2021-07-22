using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public class Department
    {
        [Key] public int DepartmentId { get; set; }
        [MaxLength(500)] public string DepartmentName { get; set; }
    }
}
