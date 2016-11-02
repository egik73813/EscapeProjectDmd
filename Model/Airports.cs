namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.Airports")]
    public partial class Airports
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Airport_id { get; set; }

        public long City_id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual Cities Cities { get; set; }
    }
}
