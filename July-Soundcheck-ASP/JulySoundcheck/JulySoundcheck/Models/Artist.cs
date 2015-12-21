using System.Collections.Generic;

namespace JulySoundcheck.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        public virtual List<Album> Albums { get; set; }
        public virtual List<Review> Reviews { get; set; }

    }
}