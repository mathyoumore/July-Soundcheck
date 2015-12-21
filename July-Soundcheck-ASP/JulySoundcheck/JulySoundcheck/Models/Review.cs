using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JulySoundcheck.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public User User { get; set; }
        public int RevieweeId { get; set; }
        public float Rating { get; set; }
        public Album Album { get; set; }
        public int AlbumId { get; set; }
        public string ContentsShort { get; set; }
        public string ContentsLong { get; set; }
        public DbSet<User> Users { get; set; }
    }
}