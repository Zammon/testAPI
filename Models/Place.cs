using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestAPI.Models
{
    [Table("Places", Schema = "dropsideways_backend")]
    public partial class Place
    {
        [Key]
        [StringLength(10)]
        public string IdPlace { get; set; } = null!;
        [StringLength(10)]
        public string IdPost { get; set; } = null!;
        [Column("namePlace")]
        [StringLength(100)]
        public string NamePlace { get; set; } = null!;

        [ForeignKey("IdPlace")]
        [InverseProperty("Place")]
        public virtual Post IdPlaceNavigation { get; set; } = null!;
    }
}
