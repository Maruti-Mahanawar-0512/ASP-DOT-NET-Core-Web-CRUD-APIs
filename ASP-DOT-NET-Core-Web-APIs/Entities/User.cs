using System.ComponentModel.DataAnnotations;

namespace ASP_DOT_NET_Core_Web_APIs.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }= Guid.NewGuid();
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
