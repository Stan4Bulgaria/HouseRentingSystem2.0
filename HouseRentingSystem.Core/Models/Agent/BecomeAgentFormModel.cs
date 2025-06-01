using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem2._0.Core.Constants.MessageConstants;
using static HouseRentingSystem2._0.Infrastructure.Data.DataConstants.Agent;
namespace HouseRentingSystem2._0.Core.Models.Agent
{
    public class BecomeAgentFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(
            PhoneNumberMaxLenth, 
            MinimumLength = PhoneNumberMinLength,
            ErrorMessage = LengthMessage
            )]
        [Display(Name = "Phone Number")]
        [Phone]
        public string PhoneNumber { get; set; } = null!;
    }
}
 