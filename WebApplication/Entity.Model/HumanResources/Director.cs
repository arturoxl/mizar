using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Entity.Model
{
    [Table("Director")]
    public partial class Director
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idDirector { get; set; }

        [Column("directorsName")]
        [StringLength(50)]
        public string nameDirector { get; set; }

        [StringLength(50)]
        public string nacionality { get; set; }
    }
}
