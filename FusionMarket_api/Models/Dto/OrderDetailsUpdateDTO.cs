using System.ComponentModel.DataAnnotations;

namespace FusionMarket_api.Models.Dto
{
    public class OrderDetailsUpdateDTO
    {
        [Required]
        public int OrderDetailId { get; set; }
        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }
    }
}
