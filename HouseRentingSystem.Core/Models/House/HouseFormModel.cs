using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem2._0.Infrastructure.Data.DataConstants.House;
using static HouseRentingSystem2._0.Core.Constants.MessageConstants;
namespace HouseRentingSystem2._0.Core.Models.House
{
    public class HouseFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(TitleMaxLength,
            MinimumLength = TitleMinLength,
            ErrorMessage = LengthMessage)]
        public string Title { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(AddressMaxLength,
            MinimumLength = AddressMinLength,
            ErrorMessage = LengthMessage)]
        public string Address { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(DescriptionMaxLength,
            MinimumLength = DescriptionMinLength,
            ErrorMessage = LengthMessage)] 
        public string Description { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        [Range(typeof(decimal), PricePerMonthMinValue, PricePerMonthMaxValue, ErrorMessage = "Price per month must be a positive number and less than {2} leva")]
        [Display(Name = "Price Per Month")]
        public decimal PricePerMonth { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public IEnumerable<HouseCategoryServiceModel> Categories { get; set; } = new List<HouseCategoryServiceModel>();
    }
}
