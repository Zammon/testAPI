using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestAPI.Models
{
    [Table("User_Profiles", Schema = "dropsideways_backend")]
    public partial class UserProfile
    {
        [Key]
        [Column("id_user_profile")]
        public int IdUserProfile { get; set; }
        [Column("userprofile")]
        [StringLength(100)]
        public string? Userprofile1 { get; set; }
        [Column("coverprofile")]
        [StringLength(100)]
        public string? Coverprofile { get; set; }
        [Column("nickname")]
        [StringLength(50)]
        public string? Nickname { get; set; }
        [Column("status_nickname")]
        [StringLength(50)]
        public string StatusNickname { get; set; } = null!;
        [Column("status_aboutme")]
        [StringLength(50)]
        public string StatusAboutme { get; set; } = null!;
    }
}
