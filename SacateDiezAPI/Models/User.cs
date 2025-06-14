using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SacateDiezAPI.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
    }
}