namespace BiletOtomasyon.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("salonunKoltuklari")]
    public partial class salonunKoltuklari
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public salonunKoltuklari()
        {
            Satis = new HashSet<Satis>();
        }

        public int id { get; set; }

        public int salonID { get; set; }

        public int koltukID { get; set; }

        public bool? status { get; set; }

        public virtual Koltuk Koltuk { get; set; }

        public virtual Salon Salon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satis> Satis { get; set; }
    }
}
