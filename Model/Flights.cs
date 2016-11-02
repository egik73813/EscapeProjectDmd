namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.Flights")]
    public partial class Flights
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Flights()
        {
            Tickets = new HashSet<Tickets>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Flight_id { get; set; }

        public long Duration { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date_Start { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date_End { get; set; }

        public int Free_Seats { get; set; }

        public long Airlines_id { get; set; }

        public long City_from { get; set; }

        public long City_to { get; set; }

        public virtual Airlines Airlines { get; set; }

        public virtual Cities Cities { get; set; }

        public virtual Cities Cities1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}
