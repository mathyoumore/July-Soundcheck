using System.Collections.Generic;

namespace JulySoundcheck.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public Artist Artist { get; set; }
        //public int ArtistId { get; set; }
        //public virtual List<Review> Reviews { get; set; }

    }
}