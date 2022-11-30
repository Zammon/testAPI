using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestAPI.Models
{
    [Table("Staffs", Schema = "dropsideways_backend")]
    public partial class Staff
    {
        public Staff()
        {
            Posts = new HashSet<Post>();
        }

        [Key]
        [StringLength(12)]
        public string IdStaff { get; set; } = null!;
        [Column("accoutName")]
        [StringLength(20)]
        public string AccoutName { get; set; } = null!;
        [Column("password")]
        [StringLength(20)]
        public string Password { get; set; } = null!;
        [Column("firstName")]
        [StringLength(50)]
        public string FirstName { get; set; } = null!;
        [Column("lastName")]
        [StringLength(50)]
        public string LastName { get; set; } = null!;
        [Column("gender")]
        [StringLength(10)]
        public string Gender { get; set; } = null!;
        [Column("birthDay", TypeName = "date")]
        public DateTime BirthDay { get; set; }
        [Column("tel")]
        [StringLength(10)]
        [Unicode(false)]
        public string Tel { get; set; } = null!;
        [Column("statusAccout")]
        [StringLength(1)]
        [Unicode(false)]
        public string StatusAccout { get; set; } = null!;

        [InverseProperty("IdStaffNavigation")]
        public virtual ICollection<Post> Posts { get; set; }
    }
}
