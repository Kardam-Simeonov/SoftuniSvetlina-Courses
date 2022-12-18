using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Data.DataConstants.Agent;

namespace HouseRentingSystem.Data.Entities
{
    public class Agent
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; }

        [Required]
        public string UserId { get; set; }
        
        public IdentityUser User { get; init; }
    }
}
