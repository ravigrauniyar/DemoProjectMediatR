using System.ComponentModel.DataAnnotations;

namespace DemoProjectMediatR.Models
{
    public class UserEntity
    {
        [Key]
        public Guid id { get; set; }
        public string name { get; set; } = string.Empty;
        public string address { get; set; } = string.Empty;
    }
}
