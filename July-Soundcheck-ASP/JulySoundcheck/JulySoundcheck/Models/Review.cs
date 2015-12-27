using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JulySoundcheck.Models
{
    public class Review
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReviewId { get; set; }
        public virtual User Reviewee { get; set; }
        public int UserId { get; set; }
        public float Rating { get; set; }
        public Album Album { get; set; }
        public int AlbumId { get; set; }
        [Display(Name = "Short Review")]
        public string ContentsShort { get; set; }
        public string ContentsLong { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}