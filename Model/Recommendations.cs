namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.Recommendations")]
    public partial class Recommendations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Recommendation_id { get; set; }

        public int Percantage { get; set; }

        public long User_id { get; set; }

        public virtual Users Users { get; set; }
    }
}
