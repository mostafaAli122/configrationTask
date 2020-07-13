namespace Configration.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InstructorConfiguration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InstructorConfigurationsID { get; set; }

        public int InstructorID { get; set; }

        [Column("_InstructorConfigurationsKeyID")]
        public int C_InstructorConfigurationsKeyID { get; set; }

        [Required]
        [StringLength(50)]
        public string InstructorConfigurationsValue { get; set; }

        public Guid RowVer { get; set; }

        public virtual C_InstructorConfigurationKeys C_InstructorConfigurationKeys { get; set; }

        public virtual Instructor Instructor { get; set; }
    }
}
