namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.AirlinesFeedback")]
    public partial class AirlinesFeedback
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long UsersFeedback_id { get; set; }

        [Required]
        public string Text { get; set; }

        public int Grade { get; set; }

        public long User_id { get; set; }

        public long Airlines_id { get; set; }

        public virtual Airlines Airlines { get; set; }

        public virtual Users Users { get; set; }
    }
}
