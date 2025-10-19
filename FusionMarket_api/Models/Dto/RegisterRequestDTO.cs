﻿using System.ComponentModel.DataAnnotations;

namespace FusionMarket_api.Models.Dto
{
    public class RegisterRequestDTO
    {
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        public string ConfirmPassword { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}
