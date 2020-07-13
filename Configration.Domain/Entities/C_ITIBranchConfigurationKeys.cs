namespace Configration.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_ITIBranchConfigurationKeys")]
    public partial class C_ITIBranchConfigurationKeys
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_ITIBranchConfigurationKeys()
        {
            ITIBranchConfigurations = new HashSet<ITIBranchConfiguration>();
        }

        [Key]
        [Column("_ITIBranchConfigurationsKeyID")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_ITIBranchConfigurationsKeyID { get; set; }

        [Required]
        [StringLength(50)]
        public string NameE { get; set; }

        public bool IsUniqueKey { get; set; }

        [Column("_ITIBranchConfigurationKeyValue")]
        [Required]
        [StringLength(50)]
        public string C_ITIBranchConfigurationKeyValue { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITIBranchConfiguration> ITIBranchConfigurations { get; set; }
    }
}
