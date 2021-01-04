namespace BiletOtomasyon.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("filminOturumlari")]
    public partial class filminOturumlari
    {
        public int id { get; set; }

        public int? filmId { get; set; }

        public int? oturumId { get; set; }

        public virtual filmler filmler { get; set; }

        public virtual oturumlar oturumlar { get; set; }
    }
}
