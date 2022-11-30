using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestAPI.Models
{
    [Table("Filters", Schema = "dropsideways_backend")]
    public partial class Filter
    {
        public Filter()
        {
            ItemsFilters = new HashSet<ItemsFilter>();
        }

        [Key]
        public int IdFilter { get; set; }
        [Column("nameFilter")]
        [StringLength(500)]
        public string NameFilter { get; set; } = null!;

        [InverseProperty("IdFilterNavigation")]
        public virtual ICollection<ItemsFilter> ItemsFilters { get; set; }
    }
}
