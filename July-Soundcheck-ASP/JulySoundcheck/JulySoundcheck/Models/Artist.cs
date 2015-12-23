using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace JulySoundcheck.Models
{
    public class Artist
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArtistId { get; set; }
        [Display(Name = "Artist Name")]
        public string ArtistName { get; set; }
        public virtual List<Album> Albums { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public DbSet<Artist> Artists { get; set; }

    }
}