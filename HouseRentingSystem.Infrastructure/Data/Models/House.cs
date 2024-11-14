using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HouseRentingSystem2._0.Infrastructure.Data.DataConstants;

namespace HouseRentingSystem2._0.Infrastructure.Data.Models
{
    public class House
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(DataConstants.House.TitleMaxLength)]
        public string Title  { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataConstants.House.AddressMaxLength)]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataConstants.House.DescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Url]
        public string ImageUrl { get; set; } = string.Empty ;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        //[Range(typeof(decimal), DataConstants.House.PricePerMonthMinValue, DataConstants.House.PricePerMonthMaxValue, ConvertValueInInvariantCulture = true)]
       
        public decimal PricePerMonth { get; set; }

        [Required]
        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        public int AgentId { get; set; }
        [ForeignKey(nameof(AgentId))]
        public Agent Agent { get; set; } = null!;

        public string RenterId { get; set; } = string.Empty;

    }
}
