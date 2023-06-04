using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SportApplication.Models
{
    public class User
    {
        [Key]
        [EmailAddress]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Email { get; set; } = string.Empty;
        
        [Required]
        public string Firstname { get; set; } = String.Empty;

        [Required]
        public string Lastname { get; set; } = string.Empty;

        [Required]
        [PasswordPropertyText]
        public string Password { get; set; } = String.Empty;

        public string? Gender { get; set; }

        public DateTime Birthdate { get; set; }

        [JsonIgnore]
        public bool IsAdmin { get; set; }
    }
}
