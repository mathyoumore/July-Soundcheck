namespace JulySoundcheck.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<JulySoundcheck.Models.JulySoundcheckContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(JulySoundcheck.Models.JulySoundcheckContext context)
        {
            var users = new List<User>
            {
                new User { RealName = "Matt" },
                new User { RealName = "Phil" },
                new User { RealName = "Joey" },
                new User { RealName = "Chris" },
                new User { RealName = "Polio" },
                new User { RealName = "Stephen" },
                new User { RealName = "Zach" },
            };
            var artists = new List<Artist>
            {
            new Artist { ArtistName = "Amon Düül II"},
            new Artist { ArtistName = "Khann"},
            new Artist { ArtistName = "Amebix"},
            new Artist { ArtistName = "dälek"},
            new Artist { ArtistName = "Gobble Gobble"},
            new Artist { ArtistName = "Camel"},
            new Artist { ArtistName = "マス オブ ザ ファーメンティング ドレッグス(MASS OF THE FERMENTING DREGS)"}
            };
                        var albums = new List<Album>
            {
            new Album {
                AlbumName = "Yeti" ,
                Artist = artists.Single(s => s.ArtistName == "Amon Düül II")},
            new Album {
                AlbumName = "Tofutopia" ,
                Artist = artists.Single(s => s.ArtistName == "Khann")},
            new Album {
                AlbumName = "Arise" ,
                Artist = artists.Single(s => s.ArtistName == "Amebix")},
            new Album {
                AlbumName = "Absence" ,
                Artist = artists.Single(s => s.ArtistName == "dälek")},
            new Album {
                AlbumName = "Neon Graveyard" ,
                Artist = artists.Single(s => s.ArtistName == "Gobble Gobble")},
            new Album {
                AlbumName = "The Snow Goose" ,
                Artist = artists.Single(s => s.ArtistName == "Camel")},
            new Album {
                AlbumName = "ゼロコンマ、色とりどりの世界 (Zero comma, iro toridori no sekai)" ,
                Artist = artists.Single(s => s.ArtistName == "マス オブ ザ ファーメンティング ドレッグス(MASS OF THE FERMENTING DREGS)")}
            };
                        var reviews = new List<Review>
            {
            new Review {
                User = users.Single(s => s.RealName == "Joey"),
                Rating = 2,
                Album = albums.Single(s => s.AlbumName == "Yeti"),
                ContentsShort = "Complex in the best way, extremely influential"},
            new Review {
                User = users.Single(s => s.RealName == "Matt"),
                Rating = 3,
                Album = albums.Single(s => s.AlbumName == "Tofutopia"),
                ContentsShort = "Bonkers, fun, grindy, good"},
            new Review {
                User = users.Single(s => s.RealName == "Phil"),
                Rating = 1,
                Album = albums.Single(s => s.AlbumName == "Arise"),
                ContentsShort = "Metal+Punk=Crust"},
            new Review {
                User = users.Single(s => s.RealName == "Chris"),
                Rating = 2,
                Album = albums.Single(s => s.AlbumName == "Absence"),
                ContentsShort = "Good at industrial and hip-hop. Good all around."},
            new Review {
                User = users.Single(s => s.RealName == "Stephen"),
                Rating = 3,
                Album = albums.Single(s => s.AlbumName == "Neon Graveyard"),
                ContentsShort = "folky/noisy at times, great variation, distorted vocals, very good"},
            new Review {
                User = users.Single(s => s.RealName == "Polio"),
                Rating = 2,
                Album = albums.Single(s => s.AlbumName == "The Snow Goose"),
                ContentsShort = "Pretty good. Delivered promised prog/symphonic rock."},
            new Review {
                User = users.Single(s => s.RealName == "Joey"),
                Rating = 2,
                Album = albums.Single(s => s.AlbumName == "ゼロコンマ、色とりどりの世界 (Zero comma, iro toridori no sekai)"),
                ContentsShort = "Loads of fun. Fantastic vocals."}
            };

            artists.ForEach(s => context.Artists.AddOrUpdate(p => p.ArtistName, s));
            albums.ForEach(s => context.Albums.AddOrUpdate(p => p.AlbumName, s));
            reviews.ForEach(s => context.Reviews.AddOrUpdate(p => p.AlbumId, s));
            context.SaveChanges();

        }
    }
}
