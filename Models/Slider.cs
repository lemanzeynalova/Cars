﻿using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace Cars.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required, MinLength(3),MaxLength(128),DataType("nvarchar")]
        public string Title { get; set; }
        [Required, MinLength(3), MaxLength(128),DataType("varchar")]
        public string Text { get; set; }
        public bool? IsLeft { get; set; }
    }
}
