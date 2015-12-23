using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace JulySoundcheck.Models
{
    public class Album
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AlbumId { get; set; }
        [Display(Name = "Album Title")]
        public string AlbumName { get; set; }
        [Display(Name = "Artist")]
        public virtual Artist Artist { get; set; }
        public int ArtistId { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public DbSet<Album> Albums { get; set; }

    }
}