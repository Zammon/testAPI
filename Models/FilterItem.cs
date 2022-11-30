using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestAPI.Models
{
    [Table("Filter_Items", Schema = "dropsideways_backend")]
    public partial class FilterItem
    {
        [Key]
        [Column("id_filter_item")]
        public int IdFilterItem { get; set; }
        [Column("id_filter")]
        public int IdFilter { get; set; }
        [Column("itemname")]
        [StringLength(50)]
        public string Itemname { get; set; } = null!;

        [ForeignKey("IdFilter")]
        [InverseProperty("FilterItems")]
        public virtual Filter IdFilterNavigation { get; set; } = null!;
    }
}
