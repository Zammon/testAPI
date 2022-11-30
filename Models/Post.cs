using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestAPI.Models
{
    [Table("Posts", Schema = "dropsideways_backend")]
    public partial class Post
    {
        public Post()
        {
            Images = new HashSet<Image>();
        }

        [Key]
        [StringLength(10)]
        public string IdPost { get; set; } = null!;
        [StringLength(12)]
        public string IdStaff { get; set; } = null!;
        [Column("type")]
        [StringLength(20)]
        public string Type { get; set; } = null!;
        [Column("title")]
        [StringLength(1000)]
        public string Title { get; set; } = null!;
        [Column("directory")]
        [StringLength(1000)]
        public string? Directory { get; set; }
        [Column("datePost", TypeName = "date")]
        public DateTime DatePost { get; set; }
        [Column("timePost")]
        public TimeSpan TimePost { get; set; }
        [Column("tagsPost")]
        [StringLength(100)]
        public string TagsPost { get; set; } = null!;
        [Column("areaLost")]
        [StringLength(50)]
        public string AreaLost { get; set; } = null!;
        [Column("statusPost")]
        [StringLength(1)]
        [Unicode(false)]
        public string StatusPost { get; set; } = null!;

        [ForeignKey("IdStaff")]
        [InverseProperty("Posts")]
        public virtual Staff IdStaffNavigation { get; set; } = null!;
        [InverseProperty("IdPlaceNavigation")]
        public virtual Place? Place { get; set; }
        [InverseProperty("IdPostNavigation")]
        public virtual ICollection<Image> Images { get; set; }
    }
}
