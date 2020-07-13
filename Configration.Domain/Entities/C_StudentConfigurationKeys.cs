namespace Configration.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_StudentConfigurationKeys")]
    public partial class C_StudentConfigurationKeys
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_StudentConfigurationKeys()
        {
            StudentConfigurations = new HashSet<StudentConfiguration>();
        }

        [Key]
        [Column("_StudentConfigurationsKeyID")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_StudentConfigurationsKeyID { get; set; }

        [Required]
        [StringLength(50)]
        public string NameE { get; set; }

        public bool IsUniqueKey { get; set; }

        [Column("_StudentConfigurationKeyValue")]
        [Required]
        [StringLength(50)]
        public string C_StudentConfigurationKeyValue { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentConfiguration> StudentConfigurations { get; set; }
    }
}
