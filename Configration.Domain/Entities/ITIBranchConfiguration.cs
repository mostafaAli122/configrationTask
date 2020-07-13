namespace Configration.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ITIBranchConfiguration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ITIBranchConfigurationsID { get; set; }

        public int ITIBranchID { get; set; }

        [Column("_ITIBranchConfigurationsKeyID")]
        public int C_ITIBranchConfigurationsKeyID { get; set; }

        [Required]
        [StringLength(50)]
        public string ITIBranchConfigurationsValue { get; set; }

        public Guid RowVer { get; set; }

        public virtual C_ITIBranchConfigurationKeys C_ITIBranchConfigurationKeys { get; set; }

        public virtual ITIBranch ITIBranch { get; set; }
    }
}
