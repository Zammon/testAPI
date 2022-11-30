using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestAPI.Models
{
    [Table("Tag_Posts", Schema = "dropsideways_backend")]
    public partial class TagPost
    {
        [Key]
        [Column("id_tag_post")]
        public int IdTagPost { get; set; }
        [Column("id_post")]
        public int IdPost { get; set; }
        [Column("id_tag")]
        public int IdTag { get; set; }

        [ForeignKey("IdPost")]
        [InverseProperty("TagPosts")]
        public virtual Post IdPostNavigation { get; set; } = null!;
        [ForeignKey("IdTag")]
        [InverseProperty("TagPosts")]
        public virtual Tag IdTagNavigation { get; set; } = null!;
    }
}
