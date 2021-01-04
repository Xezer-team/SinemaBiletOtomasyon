namespace BiletOtomasyon.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Koltuk")]
    public partial class Koltuk
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Koltuk()
        {
            salonunKoltuklari = new HashSet<salonunKoltuklari>();
        }

        public int id { get; set; }

        [StringLength(20)]
        public string koltukAdi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<salonunKoltuklari> salonunKoltuklari { get; set; }
    }
}
