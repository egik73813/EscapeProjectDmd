namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.Timezone")]
    public partial class Timezone
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Timezone_id { get; set; }

        public int Value { get; set; }

        public long City_id { get; set; }

        public virtual Cities Cities { get; set; }
    }
}
