using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Data.DataConstants.Agent;

namespace HouseRentingSystem.Models.Agents
{
    public class BecomeAgentFormModel
    {
        [Required]
        [StringLength(PhoneNumberMaxLength, MinimumLength = PhoneNumberMinLength)]
        [Phone]
        public string PhoneNumber { get; set; }
    }
}
