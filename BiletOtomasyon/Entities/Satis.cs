namespace BiletOtomasyon.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Satis
    {
        public int id { get; set; }

        public decimal? tutar { get; set; }

        public DateTime? tarih { get; set; }

        public int? odemeSekliID { get; set; }

        [StringLength(50)]
        public string musteriAd { get; set; }

        [StringLength(50)]
        public string musteriSoyad { get; set; }

        public int? filmID { get; set; }

        public int? salonKoltukID { get; set; }

        public virtual filmler filmler { get; set; }

        public virtual odemeSekli odemeSekli { get; set; }

        public virtual salonunKoltuklari salonunKoltuklari { get; set; }
    }
}
