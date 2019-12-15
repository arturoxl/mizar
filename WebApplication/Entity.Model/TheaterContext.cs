namespace Entity.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TheaterContext : DbContext
    {
        public TheaterContext()
            : base("name=TheaterConnection")
        {
        }

        public virtual DbSet<Actor> Actor { get; set; }
        public virtual DbSet<Film> Film { get; set; }
        public virtual DbSet<Cinema> Cinema { get; set; }
        public virtual DbSet<Director> Director { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Actor>()
                .Property(e => e.lastname)
                .IsUnicode(false);

            modelBuilder.Entity<Film>()
                .Property(e => e.nameFilm)
                .IsUnicode(false);

            modelBuilder.Entity<Film>()
                .Property(e => e.producer)
                .IsUnicode(false);

            modelBuilder.Entity<Cinema>()
                 .Property(e => e.nameCinema)
                 .IsUnicode(false);

            modelBuilder.Entity<Director>()
                 .Property(e => e.nameDirector)
                 .IsUnicode(false);

            modelBuilder.Entity<Director>()
                .Property(e => e.nacionality)
                .IsUnicode(false);
        }
    }
}
