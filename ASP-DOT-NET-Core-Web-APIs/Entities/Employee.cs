using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace ASP_DOT_NET_Core_Web_APIs.Entities
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifyDate { get; set; }
        public DateOnly? DOB { get; set; }
        public string? Position { get; set; }
        public string? Department { get; set; }
        public string? EmailAddress { get; set; }
    }
}
