namespace Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EscapeModel : DbContext
    {
        public EscapeModel()
            : base("name=EscapeModel")
        {
        }

        public virtual DbSet<Airlines> Airlines { get; set; }
        public virtual DbSet<AirlinesFeedback> AirlinesFeedback { get; set; }
        public virtual DbSet<Airports> Airports { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<CitiesFeedback> CitiesFeedback { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Flights> Flights { get; set; }
        public virtual DbSet<Geozone> Geozone { get; set; }
        public virtual DbSet<NotNeedVisa> NotNeedVisa { get; set; }
        public virtual DbSet<Recommendations> Recommendations { get; set; }
        public virtual DbSet<Tickets> Tickets { get; set; }
        public virtual DbSet<Timezone> Timezone { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airlines>()
                .HasMany(e => e.AirlinesFeedback)
                .WithRequired(e => e.Airlines)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Airlines>()
                .HasMany(e => e.Flights)
                .WithRequired(e => e.Airlines)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Airports>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Cities>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Cities>()
                .HasMany(e => e.Airports)
                .WithRequired(e => e.Cities)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cities>()
                .HasMany(e => e.CitiesFeedback)
                .WithRequired(e => e.Cities)
                .HasForeignKey(e => e.Cities_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cities>()
                .HasMany(e => e.Flights)
                .WithRequired(e => e.Cities)
                .HasForeignKey(e => e.City_from)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cities>()
                .HasMany(e => e.Flights1)
                .WithRequired(e => e.Cities1)
                .HasForeignKey(e => e.City_to)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cities>()
                .HasMany(e => e.Timezone)
                .WithRequired(e => e.Cities)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Countries>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Countries>()
                .HasMany(e => e.Cities)
                .WithRequired(e => e.Countries)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Countries>()
                .HasMany(e => e.NotNeedVisa)
                .WithRequired(e => e.Countries)
                .HasForeignKey(e => e.Country_From)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Countries>()
                .HasMany(e => e.NotNeedVisa1)
                .WithRequired(e => e.Countries1)
                .HasForeignKey(e => e.Country_To)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Flights>()
                .HasMany(e => e.Tickets)
                .WithRequired(e => e.Flights)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Geozone>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Geozone>()
                .HasMany(e => e.Countries)
                .WithRequired(e => e.Geozone)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Firstname)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.Lastname)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.Login)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.Permanent_Country)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .HasMany(e => e.AirlinesFeedback)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.CitiesFeedback)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Recommendations)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Tickets)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);
        }
    }
}
