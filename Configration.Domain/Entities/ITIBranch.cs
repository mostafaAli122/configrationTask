namespace Configration.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ITIBranchs")]
    public partial class ITIBranch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ITIBranch()
        {
            ITIBranchConfigurations = new HashSet<ITIBranchConfiguration>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ITIBranchID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITIBranchConfiguration> ITIBranchConfigurations { get; set; }
    }
}
