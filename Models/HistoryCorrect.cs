using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestAPI.Models
{
    [Table("History_Correct", Schema = "dropsideways_backend")]
    public partial class HistoryCorrect
    {
        [Key]
        [Column("id_history_correct")]
        public int IdHistoryCorrect { get; set; }
        [Column("correct_by")]
        public int CorrectBy { get; set; }
        [Column("report_by")]
        public int ReportBy { get; set; }
        [Column("type_history")]
        [StringLength(5)]
        [Unicode(false)]
        public string TypeHistory { get; set; } = null!;
        [Column("targetReport")]
        public int TargetReport { get; set; }
        [Column("correct_latest")]
        [StringLength(1)]
        [Unicode(false)]
        public string CorrectLatest { get; set; } = null!;
        [Column("correct_before")]
        [StringLength(1)]
        [Unicode(false)]
        public string? CorrectBefore { get; set; }

        [ForeignKey("CorrectBy")]
        [InverseProperty("HistoryCorrects")]
        public virtual Admin CorrectByNavigation { get; set; } = null!;
    }
}
