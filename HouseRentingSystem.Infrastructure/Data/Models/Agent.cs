using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HouseRentingSystem2._0.Infrastructure.Data.Models
{
    public class Agent
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(DataConstants.Agent.PhoneNumberMaxLenth)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        public ICollection<House> Houses { get; set; } = new List<House>();
    }
}
