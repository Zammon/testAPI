using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestAPI.Models
{
    [Table("Place_Posts", Schema = "dropsideways_backend")]
    public partial class PlacePost
    {
        [Key]
        [Column("id_place_post")]
        public int IdPlacePost { get; set; }
        [Column("id_post")]
        public int IdPost { get; set; }
        [Column("id_place")]
        public int IdPlace { get; set; }
        [Column("type_place")]
        [StringLength(1)]
        [Unicode(false)]
        public string TypePlace { get; set; } = null!;

        [ForeignKey("IdPlace")]
        [InverseProperty("PlacePosts")]
        public virtual Place IdPlaceNavigation { get; set; } = null!;
        [ForeignKey("IdPost")]
        [InverseProperty("PlacePosts")]
        public virtual Post IdPostNavigation { get; set; } = null!;
    }
}
