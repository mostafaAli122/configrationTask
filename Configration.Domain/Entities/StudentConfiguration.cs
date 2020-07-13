namespace Configration.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class StudentConfiguration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentConfigurationsID { get; set; }

        public int StudentID { get; set; }

        [Column("_StudentConfigurationsKeyID")]
        public int C_StudentConfigurationsKeyID { get; set; }

        [Required]
        [StringLength(50)]
        public string StudentConfigurationsValue { get; set; }

        public Guid RowVer { get; set; }

        public virtual C_StudentConfigurationKeys C_StudentConfigurationKeys { get; set; }

        public virtual Student Student { get; set; }
    }
}
