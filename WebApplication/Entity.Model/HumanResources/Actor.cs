namespace Entity.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Actor")]
    public partial class Actor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idActor { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string lastname { get; set; }

        public int? age { get; set; }
    }
}
