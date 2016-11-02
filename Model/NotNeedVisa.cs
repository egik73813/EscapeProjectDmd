namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.NotNeedVisa")]
    public partial class NotNeedVisa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Visa_id { get; set; }

        public long Country_From { get; set; }

        public long Country_To { get; set; }

        public bool? Visa_condition { get; set; }

        public virtual Countries Countries { get; set; }

        public virtual Countries Countries1 { get; set; }
    }
}
