namespace th_lesson10.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MusicStoreContext : DbContext
    {
        public MusicStoreContext()
            : base("name=MusicStoreConnection")
        {
        }

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
    }
}
