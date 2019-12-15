namespace Entity.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cinema")]
    public partial class Cinema
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idCinema { get; set; }

        [StringLength(50)]
        public string nameCinema { get; set; }
    }
}
