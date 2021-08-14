using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RecipeApp.Models
{
    public class User : BaseModel
    {
        [Required, MinLength(2), MaxLength(50)]
        public string Username { get; set; }
        [Required, MinLength(8), MaxLength(512)]
        public string Password { get; set; }
    }
}