using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestAPI.Models
{
    [Table("Users", Schema = "dropsideways_backend")]
    public partial class User
    {
        [Key]
        [Column("id_user")]
        public int IdUser { get; set; }
        [Column("accoutname")]
        [StringLength(50)]
        public string Accoutname { get; set; } = null!;
        [Column("password")]
        [StringLength(50)]
        public string Password { get; set; } = null!;
        [Column("type_user")]
        [StringLength(50)]
        public string TypeUser { get; set; } = null!;
        [Column("firstname")]
        [StringLength(20)]
        public string Firstname { get; set; } = null!;
        [Column("lastname")]
        [StringLength(20)]
        public string Lastname { get; set; } = null!;
        [Column("gender")]
        [StringLength(5)]
        public string Gender { get; set; } = null!;
        [Column("birthday", TypeName = "date")]
        public DateTime Birthday { get; set; }
        [Column("faculty")]
        [StringLength(80)]
        public string? Faculty { get; set; }
        [Column("branch")]
        [StringLength(80)]
        public string? Branch { get; set; }
        [Column("education")]
        [StringLength(50)]
        public string? Education { get; set; }
        [Column("status_accout")]
        [StringLength(50)]
        public string StatusAccout { get; set; } = null!;
    }
}
