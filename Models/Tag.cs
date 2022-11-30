using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestAPI.Models
{
    [Table("Tags", Schema = "dropsideways_backend")]
    public partial class Tag
    {
        public Tag()
        {
            TagPosts = new HashSet<TagPost>();
        }

        [Key]
        [Column("id_tag")]
        public int IdTag { get; set; }
        [Column("nametag")]
        [StringLength(50)]
        public string Nametag { get; set; } = null!;

        [InverseProperty("IdTagNavigation")]
        public virtual ICollection<TagPost> TagPosts { get; set; }
    }
}
