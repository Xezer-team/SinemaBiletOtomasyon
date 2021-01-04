namespace BiletOtomasyon.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("filmler")]
    public partial class filmler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public filmler()
        {
            filminOturumlari = new HashSet<filminOturumlari>();
            Satis = new HashSet<Satis>();
        }

        public int id { get; set; }

        [StringLength(50)]
        public string filmAdi { get; set; }

        public int? filmSalonID { get; set; }

        public int FilmTurID { get; set; }

        public int? filmTarziID { get; set; }

        [StringLength(4)]
        public string filmYil { get; set; }

        [StringLength(100)]
        public string filmResim { get; set; }

        public bool? status { get; set; }

        public decimal? fiyat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<filminOturumlari> filminOturumlari { get; set; }

        public virtual filmTarzi filmTarzi { get; set; }

        public virtual filmTurleri filmTurleri { get; set; }

        public virtual Salon Salon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satis> Satis { get; set; }
    }
}
