﻿using System.ComponentModel.DataAnnotations;

namespace FusionMarket_api.Models.Dto
{
    public class MenuItemCreateDTO
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string SpecialTag { get; set; } = string.Empty;
        [Range(1, 1000)]
        public double Price { get; set; }
        public IFormFile File { get; set; } = null!;
    }
}
