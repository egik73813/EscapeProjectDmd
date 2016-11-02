namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.CitiesFeedback")]
    public partial class CitiesFeedback
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long UsersFeedback_id { get; set; }

        [Required]
        public string Text { get; set; }

        public int Grade { get; set; }

        public long User_id { get; set; }

        public long Cities_id { get; set; }

        public virtual Cities Cities { get; set; }

        public virtual Users Users { get; set; }
    }
}
