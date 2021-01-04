namespace BiletOtomasyon.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oturumlar")]
    public partial class oturumlar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public oturumlar()
        {
            filminOturumlari = new HashSet<filminOturumlari>();
        }

        public int id { get; set; }

        [StringLength(50)]
        public string oturum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<filminOturumlari> filminOturumlari { get; set; }
    }
}
