namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.Tickets")]
    public partial class Tickets
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Ticket_number { get; set; }

        public long User_id { get; set; }

        public long Flight_id { get; set; }

        public virtual Flights Flights { get; set; }

        public virtual Users Users { get; set; }
    }
}
