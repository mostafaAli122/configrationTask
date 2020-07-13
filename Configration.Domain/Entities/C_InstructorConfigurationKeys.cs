namespace Configration.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_InstructorConfigurationKeys")]
    public partial class C_InstructorConfigurationKeys
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_InstructorConfigurationKeys()
        {
            InstructorConfigurations = new HashSet<InstructorConfiguration>();
        }

        [Key]
        [Column("_InstructorConfigurationsKeyID")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_InstructorConfigurationsKeyID { get; set; }

        [Required]
        [StringLength(50)]
        public string NameE { get; set; }

        public bool IsUniqueKey { get; set; }

        [Column("_InstructorConfigurationKeyValue")]
        [Required]
        [StringLength(50)]
        public string C_InstructorConfigurationKeyValue { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstructorConfiguration> InstructorConfigurations { get; set; }
    }
}
