using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestAPI.Models
{
    [Table("Images", Schema = "dropsideways_backend")]
    public partial class Image
    {
        [Key]
        [StringLength(10)]
        public string IdImage { get; set; } = null!;
        [StringLength(10)]
        public string IdPost { get; set; } = null!;
        [Column("nameImage")]
        [StringLength(500)]
        public string NameImage { get; set; } = null!;

        [ForeignKey("IdPost")]
        [InverseProperty("Images")]
        public virtual Post IdPostNavigation { get; set; } = null!;
    }
}
