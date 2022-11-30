using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestAPI.Models
{
    [Table("ItemsFilter", Schema = "dropsideways_backend")]
    public partial class ItemsFilter
    {
        [Key]
        public int IdItemFilter { get; set; }
        public int IdFilter { get; set; }
        [Column("nameItemFiter")]
        [StringLength(500)]
        public string NameItemFiter { get; set; } = null!;

        [ForeignKey("IdFilter")]
        [InverseProperty("ItemsFilters")]
        public virtual Filter IdFilterNavigation { get; set; } = null!;
    }
}
