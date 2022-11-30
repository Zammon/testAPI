using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestAPI.Models
{
    [Table("Contacts", Schema = "dropsideways_backend")]
    public partial class Contact
    {
        [Key]
        [Column("id_contact")]
        public int IdContact { get; set; }
        [Column("id_user")]
        public int IdUser { get; set; }
        [Column("tel_phone")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TelPhone { get; set; }
        [Column("facebook")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Facebook { get; set; }
        [Column("lineID")]
        [StringLength(50)]
        [Unicode(false)]
        public string? LineId { get; set; }
    }
}
