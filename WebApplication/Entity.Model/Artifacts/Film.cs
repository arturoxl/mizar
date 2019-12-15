namespace Entity.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Film")]
    public partial class Film
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idFilm { get; set; }

        [StringLength(50)]
        public string nameFilm { get; set; }

        [StringLength(50)]
        public string producer { get; set; }

        public int? year { get; set; }
    }
}
