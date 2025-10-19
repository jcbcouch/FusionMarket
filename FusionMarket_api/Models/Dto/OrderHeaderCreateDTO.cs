﻿using System.ComponentModel.DataAnnotations;

namespace FusionMarket_api.Models.Dto
{
    public class OrderHeaderCreateDTO
    {
        [Required]
        public string PickUpName { get; set; } = string.Empty;
        [Required]
        public string PickUpPhoneNumber { get; set; } = string.Empty;
        [Required]
        public string PickUpEmail { get; set; } = string.Empty;

        public string ApplicationUserId { get; set; } = string.Empty;

        public double OrderTotal { get; set; }

        public int TotalItem { get; set; }

        public List<OrderDetailsCreateDTO> OrderDetailsDTO { get; set; } = new();
    }
}
