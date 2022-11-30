using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestAPI.Models
{
    [Table("Address", Schema = "dropsideways_backend")]
    public partial class Address
    {
        [Key]
        [Column("id_address")]
        public int IdAddress { get; set; }
        [Column("id_user")]
        public int IdUser { get; set; }
        [Column("type_user")]
        [StringLength(20)]
        [Unicode(false)]
        public string TypeUser { get; set; } = null!;
        [Column("alley")]
        [StringLength(20)]
        [Unicode(false)]
        public string? Alley { get; set; }
        [Column("road")]
        [StringLength(20)]
        [Unicode(false)]
        public string? Road { get; set; }
        [Column("country")]
        [StringLength(25)]
        [Unicode(false)]
        public string? Country { get; set; }
        [Column("district")]
        [StringLength(25)]
        [Unicode(false)]
        public string? District { get; set; }
        [Column("province")]
        [StringLength(25)]
        [Unicode(false)]
        public string? Province { get; set; }
        [Column("zipcode")]
        [StringLength(5)]
        [Unicode(false)]
        public string? Zipcode { get; set; }
        [Column("city")]
        [StringLength(80)]
        [Unicode(false)]
        public string? City { get; set; }
        [Column("tel_home")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TelHome { get; set; }
    }
}
