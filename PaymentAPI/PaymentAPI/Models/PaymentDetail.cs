using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public class PaymentDetail
    {
        [Key] public int Id { get; set; }
        [MaxLength(100)] public string CardOwnerName { get; set; }
        [MaxLength(16)] public string CardNumber { get; set; }
        [MaxLength(5)] public string ExpirationDate { get; set; }
        [MaxLength(3)] public string SecurityCode { get; set; }

    }
}
