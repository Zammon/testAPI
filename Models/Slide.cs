using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestAPI.Models
{
    [Table("Slides", Schema = "dropsideways_backend")]
    public partial class Slide
    {
        [Key]
        [StringLength(10)]
        public string IdSlide { get; set; } = null!;
        [Column("nameSlide")]
        [StringLength(100)]
        public string? NameSlide { get; set; }
    }
}
