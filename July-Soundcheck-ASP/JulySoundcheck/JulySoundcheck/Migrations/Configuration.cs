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
            ContextKey = "JulySoundcheck.Models.JulySoundcheckContext";
        }

        protected override void Seed(JulySoundcheck.Models.JulySoundcheckContext context)
        {

            var users = new List<User>
            {
                new User { DisplayName = "mathyoumore", RealName = "Matt"},
                new User { DisplayName = "philstone", RealName = "Phil"},
                new User { DisplayName = "chrisrad", RealName = "Chris"},
                new User { DisplayName = "joerad", RealName = "Joey"},
                new User { DisplayName = "turkey", RealName = "Stephen"},
                new User { DisplayName = "who", RealName = "Nick"},
                new User { DisplayName = "waterbuffalo", RealName = "Zach"},
                new User { DisplayName = "polio", RealName = "Polio"},
            };

            var artists = new List<Artist>
            {
                new Artist { ArtistName = "Amon Düül II"},
                new Artist { ArtistName = "Khann"},
                new Artist { ArtistName = "Amebix"},
                new Artist { ArtistName = "dälek"},
                new Artist { ArtistName = "Gobble Gobble"},
                new Artist { ArtistName = "Camel"},
                new Artist { ArtistName = "Antisect"},
                new Artist { ArtistName = "Actress"},
                new Artist { ArtistName = "The Psychic Paramount"},
                new Artist { ArtistName = "The World/Inferno Friendship Society"},
                new Artist { ArtistName = "The Bronx"},
                new Artist { ArtistName = "Jim Guthrie"},
                new Artist { ArtistName = "Todd Terje"},
                new Artist { ArtistName = "Shining"},
                new Artist { ArtistName = "Ornette Coleman"},
                new Artist { ArtistName = "American Football"},
                new Artist { ArtistName = "Gelatinus Cube"},
                new Artist { ArtistName = "Klaus Nomi"},
                new Artist { ArtistName = "Celeste"},
                new Artist { ArtistName = "Cloakroom"},
                new Artist { ArtistName = "Football, Etc."},
                new Artist { ArtistName = "Man is The Bastard"},
                new Artist { ArtistName = "Onionoise"},
                new Artist { ArtistName = "A Place to Bury Strangers"},
                new Artist { ArtistName = "Pizzicato five"},
                new Artist { ArtistName = "Anathema"},
                new Artist { ArtistName = "Bobby Womack"},
                new Artist { ArtistName = "The Churchills"},
                new Artist { ArtistName = "The Men"},
                new Artist { ArtistName = "Donnie Trumpet & the Social Experiment"},
                new Artist { ArtistName = "Renaissance"},
                new Artist { ArtistName = "Cetus"},
                new Artist { ArtistName = "Young Fathers"},
                new Artist { ArtistName = "Kortatu"},
                new Artist { ArtistName = "oOoOO"},
                new Artist { ArtistName = "Be forest"},
                new Artist { ArtistName = "Cult of Luna"},
                new Artist { ArtistName = "METZ"},
                new Artist { ArtistName = "Dali's Llama"},
                new Artist { ArtistName = "Apparat"},
                new Artist { ArtistName = "Sinkane"},
                new Artist { ArtistName = "Ghost Bath"},
                new Artist { ArtistName = "Woods of Desolation"},
                new Artist { ArtistName = "An Autumn For Crippled Children"},
                new Artist { ArtistName = "Locrian"},
                new Artist { ArtistName = "Lantlôs"},
                new Artist { ArtistName = "Max Roach"},
                new Artist { ArtistName = "Witch Cult"},
                new Artist { ArtistName = "Fister"},
                new Artist { ArtistName = "Эпос (trans: Epos)"},
                new Artist { ArtistName = "Charnia"},
                new Artist { ArtistName = "Midori"},
                new Artist { ArtistName = "Napalm Death"},
                new Artist { ArtistName = "The Groundhogs"},
                new Artist { ArtistName = "Ought"},
                new Artist { ArtistName = "Red Aunts"},
                new Artist { ArtistName = "Charles Mingus"},
                new Artist { ArtistName = "Karjalan Sissit"},
                new Artist { ArtistName = "Bright Eyes"},
                new Artist { ArtistName = "Buried at Sea"},
                new Artist { ArtistName = "Gorky's Zygotic Mynci"},
                new Artist { ArtistName = "Flower Travellin' Band"},
                new Artist { ArtistName = "Candlemass"},
                new Artist { ArtistName = "Motoro Faam"},
                new Artist { ArtistName = "Author & Punisher"},
                new Artist { ArtistName = "Coil"},
                new Artist { ArtistName = "Various Artists"},
                new Artist { ArtistName = "Pearls Before Swine"},
                new Artist { ArtistName = "Earth"},
                new Artist { ArtistName = "P.O.S."},
                new Artist { ArtistName = "Envy"},
                new Artist { ArtistName = "The Dirty Dozen Brass Band"},
                new Artist { ArtistName = "Cocteau Twins"},
                new Artist { ArtistName = "Umbra Nihil"},
                new Artist { ArtistName = "Kayo Dot"},
                new Artist { ArtistName = "Maudlin the Well"},
                new Artist { ArtistName = "Nujabes"},
                new Artist { ArtistName = "惑星アブノーマル (Wakusei Abnormal)"},
                new Artist { ArtistName = "Biréli Lagrène"},
                new Artist { ArtistName = "Greymachine"},
                new Artist { ArtistName = "Ephel Duath"},
                new Artist { ArtistName = "DNA"},
                new Artist { ArtistName = "Septicflesh"},
                new Artist { ArtistName = "CFCF"},
                new Artist { ArtistName = "Big Black"},
                new Artist { ArtistName = "SubRosa"},
                new Artist { ArtistName = "Fushitsusha"},
                new Artist { ArtistName = "Babatunde Olatunji"},
                new Artist { ArtistName = "Handsome Family"},
                new Artist { ArtistName = "385"},
                new Artist { ArtistName = "The Eldritch Dark"},
                new Artist { ArtistName = "Mew"},
                new Artist { ArtistName = "Хвост и Аукцыон (trans: Hvost and Auktyon)"},
                new Artist { ArtistName = "Ramona Falls"},
                new Artist { ArtistName = "Brother/Ghost"},
                new Artist { ArtistName = "Dvar"},
                new Artist { ArtistName = "Neu!"},
                new Artist { ArtistName = "Tárrega: Recuerdos de la Alhambra"},
                new Artist { ArtistName = "夢中夢 (Mutyumu)"},
                new Artist { ArtistName = "Immortal Technique"},
                new Artist { ArtistName = "Do Make Say Think"},
                new Artist { ArtistName = "The Algorithm"},
                new Artist { ArtistName = "In the Woods..."},
                new Artist { ArtistName = "The Ocean"},
                new Artist { ArtistName = "Why Do the Heathen Rage?"},
                new Artist { ArtistName = "Brothers in Law"},
                new Artist { ArtistName = "Brigher Death Now"},
                new Artist { ArtistName = "Cannibal Ox"},
                new Artist { ArtistName = "Run the Jewels"},
                new Artist { ArtistName = "Mount Fuji Doomjazz Corporation"},
                new Artist { ArtistName = "Shoppers"},
                new Artist { ArtistName = "The Week that Was"},
                new Artist { ArtistName = "Bjørn Torske"},
                new Artist { ArtistName = "Lindstrøm"},
                new Artist { ArtistName = "Active Child"},
                new Artist { ArtistName = "Young and In the Way"},
                new Artist { ArtistName = "Defiance, Ohio"},
                new Artist { ArtistName = "Harley Poe"},
                new Artist { ArtistName = "Clipping"},
                new Artist { ArtistName = "Every Time I Die"},
                new Artist { ArtistName = "Fishmans"},
                new Artist { ArtistName = "NOFX"},
                new Artist { ArtistName = "Freddie Gibbs and Madlib"},
                new Artist { ArtistName = "Ólafur Arnalds"},
                new Artist { ArtistName = "Dirty Three"},
                new Artist { ArtistName = "Future Islands"},
                new Artist { ArtistName = "Still Corners"},
                new Artist { ArtistName = "Colin Stetson"},
                new Artist { ArtistName = "Andrew Jackson Jihad"},
                new Artist { ArtistName = "Billy Woods"},
                new Artist { ArtistName = "Mario Diaz De Leon"},
                new Artist { ArtistName = "Sonic Area"},
                new Artist { ArtistName = "Mr. Twin Sister"},
                new Artist { ArtistName = "Riverside"},
                new Artist { ArtistName = "Kaizers Orchestra"},
                new Artist { ArtistName = "Gazpacho"},
                new Artist { ArtistName = "Lifelover"},
                new Artist { ArtistName = "Girlpool"},
                new Artist { ArtistName = "Billy Bragg"},
                new Artist { ArtistName = "Church"},
                new Artist { ArtistName = "Soiouxsie and the Banshees"},
                new Artist { ArtistName = "Luminous Orange"},
                new Artist { ArtistName = "Zs"},
                new Artist { ArtistName = "OOIOO"},
                new Artist { ArtistName = "Ноль (trans: Zero)"},
                new Artist { ArtistName = "Valgeir Sigurðsson"},
                new Artist { ArtistName = "DakhaBrakha"},
                new Artist { ArtistName = "Louis Sclavis Quartet"},
                new Artist { ArtistName = "Intronaut"},
                new Artist { ArtistName = "Ash Borer"},
                new Artist { ArtistName = "The Barracudas"},
                new Artist { ArtistName = "Bear in Heaven"},
                new Artist { ArtistName = "Stafrænn Hákon"},
                new Artist { ArtistName = "Triana"},
                new Artist { ArtistName = "Glasser"},
                new Artist { ArtistName = "Slint"},
                new Artist { ArtistName = "CCCP Fedeli alla linea (trans: [Something like] USSR True to the Course)"},
                new Artist { ArtistName = "The Evpatoria Report"},
                new Artist { ArtistName = "Midday Veil"},
                new Artist { ArtistName = "Steve Reich"},
                new Artist { ArtistName = "Eric Dolphy"},
                new Artist { ArtistName = "Moonface"},
                new Artist { ArtistName = "Poliça"}
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
                    AlbumName = "Out From The Void" ,
                    Artist = artists.Single(s => s.ArtistName == "Antisect")},
                new Album {
                    AlbumName = "Hazyville" ,
                    Artist = artists.Single(s => s.ArtistName == "Actress")},
                new Album {
                    AlbumName = "II" ,
                    Artist = artists.Single(s => s.ArtistName == "The Psychic Paramount")},
                new Album {
                    AlbumName = "Addicted to Bad Ideas: Peter Lorre's Twentieth Century" ,
                    Artist = artists.Single(s => s.ArtistName == "The World/Inferno Friendship Society")},
                new Album {
                    AlbumName = "The Bronx" ,
                    Artist = artists.Single(s => s.ArtistName == "The Bronx")},
                new Album {
                    AlbumName = "Sword & Scorcery EP" ,
                    Artist = artists.Single(s => s.ArtistName == "Jim Guthrie")},
                new Album {
                    AlbumName = "It's Album Time" ,
                    Artist = artists.Single(s => s.ArtistName == "Todd Terje")},
                new Album {
                    AlbumName = "Blackjazz" ,
                    Artist = artists.Single(s => s.ArtistName == "Shining")},
                new Album {
                    AlbumName = "The Shape of Jazz to Come" ,
                    Artist = artists.Single(s => s.ArtistName == "Ornette Coleman")},
                new Album {
                    AlbumName = "American Football" ,
                    Artist = artists.Single(s => s.ArtistName == "American Football")},
                new Album {
                    AlbumName = "The New Corn" ,
                    Artist = artists.Single(s => s.ArtistName == "Gelatinus Cube")},
                new Album {
                    AlbumName = "Klaus Nomi" ,
                    Artist = artists.Single(s => s.ArtistName == "Klaus Nomi")},
                new Album {
                    AlbumName = "Misanthrope (S)" ,
                    Artist = artists.Single(s => s.ArtistName == "Celeste")},
                new Album {
                    AlbumName = "Infinity" ,
                    Artist = artists.Single(s => s.ArtistName == "Cloakroom")},
                new Album {
                    AlbumName = "The Draft" ,
                    Artist = artists.Single(s => s.ArtistName == "Football, Etc.")},
                new Album {
                    AlbumName = "D.I.Y.C.D." ,
                    Artist = artists.Single(s => s.ArtistName == "Man is The Bastard")},
                new Album {
                    AlbumName = "The Vegetable Orchestra" ,
                    Artist = artists.Single(s => s.ArtistName == "Onionoise")},
                new Album {
                    AlbumName = "A Place to Bury Strangers" ,
                    Artist = artists.Single(s => s.ArtistName == "A Place to Bury Strangers")},
                new Album {
                    AlbumName = "Playboy & Playgirl" ,
                    Artist = artists.Single(s => s.ArtistName == "Pizzicato five")},
                new Album {
                    AlbumName = "Weather Systems" ,
                    Artist = artists.Single(s => s.ArtistName == "Anathema")},
                new Album {
                    AlbumName = "The Best of Bobby Womack - The Sould Years" ,
                    Artist = artists.Single(s => s.ArtistName == "Bobby Womack")},
                new Album {
                    AlbumName = "צ'רצ'ילים (trans: Churchill's) " ,
                    Artist = artists.Single(s => s.ArtistName == "The Churchills")},
                new Album {
                    AlbumName = "Open Your Heart" ,
                    Artist = artists.Single(s => s.ArtistName == "The Men")},
                new Album {
                    AlbumName = "Surf" ,
                    Artist = artists.Single(s => s.ArtistName == "Donnie Trumpet & the Social Experiment")},
                new Album {
                    AlbumName = "Scheherazade and Other Stories" ,
                    Artist = artists.Single(s => s.ArtistName == "Renaissance")},
                new Album {
                    AlbumName = "The Remnant Mass" ,
                    Artist = artists.Single(s => s.ArtistName == "Cetus")},
                new Album {
                    AlbumName = "White Men Are Black Men Too" ,
                    Artist = artists.Single(s => s.ArtistName == "Young Fathers")},
                new Album {
                    AlbumName = "Aizkolari" ,
                    Artist = artists.Single(s => s.ArtistName == "Kortatu")},
                new Album {
                    AlbumName = "S/T and Our Loving is Hurting Us" ,
                    Artist = artists.Single(s => s.ArtistName == "oOoOO")},
                new Album {
                    AlbumName = "Earthbeat" ,
                    Artist = artists.Single(s => s.ArtistName == "Be forest")},
                new Album {
                    AlbumName = "Eternal Kingdom" ,
                    Artist = artists.Single(s => s.ArtistName == "Cult of Luna")},
                new Album {
                    AlbumName = "METZ" ,
                    Artist = artists.Single(s => s.ArtistName == "METZ")},
                new Album {
                    AlbumName = "Full on Dunes" ,
                    Artist = artists.Single(s => s.ArtistName == "Dali's Llama")},
                new Album {
                    AlbumName = "Walls" ,
                    Artist = artists.Single(s => s.ArtistName == "Apparat")},
                new Album {
                    AlbumName = "Mean Love" ,
                    Artist = artists.Single(s => s.ArtistName == "Sinkane")},
                new Album {
                    AlbumName = "Moonlover" ,
                    Artist = artists.Single(s => s.ArtistName == "Ghost Bath")},
                new Album {
                    AlbumName = "As the Stars" ,
                    Artist = artists.Single(s => s.ArtistName == "Woods of Desolation")},
                new Album {
                    AlbumName = "The Long Goodbye" ,
                    Artist = artists.Single(s => s.ArtistName == "An Autumn For Crippled Children")},
                new Album {
                    AlbumName = "Return to Annihilation" ,
                    Artist = artists.Single(s => s.ArtistName == "Locrian")},
                new Album {
                    AlbumName = "Melting Sun" ,
                    Artist = artists.Single(s => s.ArtistName == "Lantlôs")},
                new Album {
                    AlbumName = "We Insist! - Freedom Suite Now" ,
                    Artist = artists.Single(s => s.ArtistName == "Max Roach")},
                new Album {
                    AlbumName = "Witch Cult " ,
                    Artist = artists.Single(s => s.ArtistName == "Witch Cult")},
                new Album {
                    AlbumName = "IV" ,
                    Artist = artists.Single(s => s.ArtistName == "Fister")},
                new Album {
                    AlbumName = "Илья (trans: Ilya)" ,
                    Artist = artists.Single(s => s.ArtistName == "Эпос (trans: Epos)")},
                new Album {
                    AlbumName = "Dageraad" ,
                    Artist = artists.Single(s => s.ArtistName == "Charnia")},
                new Album {
                    AlbumName = "Aratamemashite, Hajimemashite, Midori Desu" ,
                    Artist = artists.Single(s => s.ArtistName == "Midori")},
                new Album {
                    AlbumName = "Apex Predator - Easy Meat" ,
                    Artist = artists.Single(s => s.ArtistName == "Napalm Death")},
                new Album {
                    AlbumName = "Thank Christ for the Bomb" ,
                    Artist = artists.Single(s => s.ArtistName == "The Groundhogs")},
                new Album {
                    AlbumName = "More Than Any Other Day" ,
                    Artist = artists.Single(s => s.ArtistName == "Ought")},
                new Album {
                    AlbumName = "Ghetto Blaster" ,
                    Artist = artists.Single(s => s.ArtistName == "Red Aunts")},
                new Album {
                    AlbumName = "Epitaph" ,
                    Artist = artists.Single(s => s.ArtistName == "Charles Mingus")},
                new Album {
                    AlbumName = "Fucking Whore Society" ,
                    Artist = artists.Single(s => s.ArtistName == "Karjalan Sissit")},
                new Album {
                    AlbumName = "I'm Wide Awake, It's Morning" ,
                    Artist = artists.Single(s => s.ArtistName == "Bright Eyes")},
                new Album {
                    AlbumName = "Migration" ,
                    Artist = artists.Single(s => s.ArtistName == "Buried at Sea")},
                new Album {
                    AlbumName = "Spanish Dance Troupe" ,
                    Artist = artists.Single(s => s.ArtistName == "Gorky's Zygotic Mynci")},
                new Album {
                    AlbumName = "Satori" ,
                    Artist = artists.Single(s => s.ArtistName == "Flower Travellin' Band")},
                new Album {
                    AlbumName = "Epicus Doomicus Metallicus" ,
                    Artist = artists.Single(s => s.ArtistName == "Candlemass")},
                new Album {
                    AlbumName = "...And Watercycles" ,
                    Artist = artists.Single(s => s.ArtistName == "Motoro Faam")},
                new Album {
                    AlbumName = "Warcry" ,
                    Artist = artists.Single(s => s.ArtistName == "Author & Punisher")},
                new Album {
                    AlbumName = "Drone Machines" ,
                    Artist = artists.Single(s => s.ArtistName == "Author & Punisher")},
                new Album {
                    AlbumName = "Ursus Americanus" ,
                    Artist = artists.Single(s => s.ArtistName == "Author & Punisher")},
                new Album {
                    AlbumName = "The Ape of Naples" ,
                    Artist = artists.Single(s => s.ArtistName == "Coil")},
                new Album {
                    AlbumName = "Artificial Intelligence" ,
                    Artist = artists.Single(s => s.ArtistName == "Various Artists")},
                new Album {
                    AlbumName = "City of Gold" ,
                    Artist = artists.Single(s => s.ArtistName == "Pearls Before Swine")},
                new Album {
                    AlbumName = "Earth 2" ,
                    Artist = artists.Single(s => s.ArtistName == "Earth")},
                new Album {
                    AlbumName = "Never Better" ,
                    Artist = artists.Single(s => s.ArtistName == "P.O.S.")},
                new Album {
                    AlbumName = "Recitation" ,
                    Artist = artists.Single(s => s.ArtistName == "Envy")},
                new Album {
                    AlbumName = "My Feet Can't Fail Me Now" ,
                    Artist = artists.Single(s => s.ArtistName == "The Dirty Dozen Brass Band")},
                new Album {
                    AlbumName = "Head Over Heels" ,
                    Artist = artists.Single(s => s.ArtistName == "Cocteau Twins")},
                new Album {
                    AlbumName = "Gnoia" ,
                    Artist = artists.Single(s => s.ArtistName == "Umbra Nihil")},
                new Album {
                    AlbumName = "Coffins On Io" ,
                    Artist = artists.Single(s => s.ArtistName == "Kayo Dot")},
                new Album {
                    AlbumName = "Bath" ,
                    Artist = artists.Single(s => s.ArtistName == "Maudlin the Well")},
                new Album {
                    AlbumName = "Modal Soul" ,
                    Artist = artists.Single(s => s.ArtistName == "Nujabes")},
                new Album {
                    AlbumName = "何でも無い凶器 (Nan de mo nai kyouki)" ,
                    Artist = artists.Single(s => s.ArtistName == "惑星アブノーマル (Wakusei Abnormal)")},
                new Album {
                    AlbumName = "アナタソナタ (Anata Sonata)" ,
                    Artist = artists.Single(s => s.ArtistName == "惑星アブノーマル (Wakusei Abnormal)")},
                new Album {
                    AlbumName = "Gipsy Project" ,
                    Artist = artists.Single(s => s.ArtistName == "Biréli Lagrène")},
                new Album {
                    AlbumName = "Disconnected" ,
                    Artist = artists.Single(s => s.ArtistName == "Greymachine")},
                new Album {
                    AlbumName = "The Painters Palette" ,
                    Artist = artists.Single(s => s.ArtistName == "Ephel Duath")},
                new Album {
                    AlbumName = "DNA On DNA" ,
                    Artist = artists.Single(s => s.ArtistName == "DNA")},
                new Album {
                    AlbumName = "Titan" ,
                    Artist = artists.Single(s => s.ArtistName == "Septicflesh")},
                new Album {
                    AlbumName = "Continent" ,
                    Artist = artists.Single(s => s.ArtistName == "CFCF")},
                new Album {
                    AlbumName = "Songs About Fucking" ,
                    Artist = artists.Single(s => s.ArtistName == "Big Black")},
                new Album {
                    AlbumName = "More Constant Than the Gods" ,
                    Artist = artists.Single(s => s.ArtistName == "SubRosa")},
                new Album {
                    AlbumName = "Withdrawe, this sable Disclosure ere devot'd" ,
                    Artist = artists.Single(s => s.ArtistName == "Fushitsusha")},
                new Album {
                    AlbumName = "Drums of Passion" ,
                    Artist = artists.Single(s => s.ArtistName == "Babatunde Olatunji")},
                new Album {
                    AlbumName = "Through the trees" ,
                    Artist = artists.Single(s => s.ArtistName == "Handsome Family")},
                new Album {
                    AlbumName = "人間 (Ningen)" ,
                    Artist = artists.Single(s => s.ArtistName == "385")},
                new Album {
                    AlbumName = "Blood Ceremony" ,
                    Artist = artists.Single(s => s.ArtistName == "The Eldritch Dark")},
                new Album {
                    AlbumName = "Frengers" ,
                    Artist = artists.Single(s => s.ArtistName == "Mew")},
                new Album {
                    AlbumName = "Чайник вина (trans: Teapot of Wine)" ,
                    Artist = artists.Single(s => s.ArtistName == "Хвост и Аукцыон (trans: Hvost and Auktyon)")},
                new Album {
                    AlbumName = "Intuit" ,
                    Artist = artists.Single(s => s.ArtistName == "Ramona Falls")},
                new Album {
                    AlbumName = "Buried" ,
                    Artist = artists.Single(s => s.ArtistName == "Brother/Ghost")},
                new Album {
                    AlbumName = "Deii" ,
                    Artist = artists.Single(s => s.ArtistName == "Dvar")},
                new Album {
                    AlbumName = "Neu!" ,
                    Artist = artists.Single(s => s.ArtistName == "Neu!")},
                new Album {
                    AlbumName = "Tárrega/Narciso Yepes" ,
                    Artist = artists.Single(s => s.ArtistName == "Tárrega: Recuerdos de la Alhambra")},
                new Album {
                    AlbumName = "イリヤ (Ilya)" ,
                    Artist = artists.Single(s => s.ArtistName == "夢中夢 (Mutyumu)")},
                new Album {
                    AlbumName = "Revolutionary Vol. 2" ,
                    Artist = artists.Single(s => s.ArtistName == "Immortal Technique")},
                new Album {
                    AlbumName = "Winter Hymn Country Hymn Secret Hymn" ,
                    Artist = artists.Single(s => s.ArtistName == "Do Make Say Think")},
                new Album {
                    AlbumName = "Octopus4" ,
                    Artist = artists.Single(s => s.ArtistName == "The Algorithm")},
                new Album {
                    AlbumName = "Omnia" ,
                    Artist = artists.Single(s => s.ArtistName == "In the Woods...")},
                new Album {
                    AlbumName = "Pelagial" ,
                    Artist = artists.Single(s => s.ArtistName == "The Ocean")},
                new Album {
                    AlbumName = "The Soft Pink Truth" ,
                    Artist = artists.Single(s => s.ArtistName == "Why Do the Heathen Rage?")},
                new Album {
                    AlbumName = "Hard Times for Dreamers" ,
                    Artist = artists.Single(s => s.ArtistName == "Brothers in Law")},
                new Album {
                    AlbumName = "With Promises of Death" ,
                    Artist = artists.Single(s => s.ArtistName == "Brigher Death Now")},
                new Album {
                    AlbumName = "The Cold Vein" ,
                    Artist = artists.Single(s => s.ArtistName == "Cannibal Ox")},
                new Album {
                    AlbumName = "Run the Jewels 2" ,
                    Artist = artists.Single(s => s.ArtistName == "Run the Jewels")},
                new Album {
                    AlbumName = "Roadburn" ,
                    Artist = artists.Single(s => s.ArtistName == "Mount Fuji Doomjazz Corporation")},
                new Album {
                    AlbumName = "Silver Year" ,
                    Artist = artists.Single(s => s.ArtistName == "Shoppers")},
                new Album {
                    AlbumName = "The Week that Was" ,
                    Artist = artists.Single(s => s.ArtistName == "The Week that Was")},
                new Album {
                    AlbumName = "Kokning" ,
                    Artist = artists.Single(s => s.ArtistName == "Bjørn Torske")},
                new Album {
                    AlbumName = "Where You Go I Go Too" ,
                    Artist = artists.Single(s => s.ArtistName == "Lindstrøm")},
                new Album {
                    AlbumName = "You Are All I See" ,
                    Artist = artists.Single(s => s.ArtistName == "Active Child")},
                new Album {
                    AlbumName = "When Life Comes to Death" ,
                    Artist = artists.Single(s => s.ArtistName == "Young and In the Way")},
                new Album {
                    AlbumName = "The Great Depression" ,
                    Artist = artists.Single(s => s.ArtistName == "Defiance, Ohio")},
                new Album {
                    AlbumName = "Satan, Sex and No Regrets" ,
                    Artist = artists.Single(s => s.ArtistName == "Harley Poe")},
                new Album {
                    AlbumName = "CLPPNG" ,
                    Artist = artists.Single(s => s.ArtistName == "Clipping")},
                new Album {
                    AlbumName = "From Parts Unknown" ,
                    Artist = artists.Single(s => s.ArtistName == "Every Time I Die")},
                new Album {
                    AlbumName = "Long Season" ,
                    Artist = artists.Single(s => s.ArtistName == "Fishmans")},
                new Album {
                    AlbumName = "War on Errorism" ,
                    Artist = artists.Single(s => s.ArtistName == "NOFX")},
                new Album {
                    AlbumName = "Pinata" ,
                    Artist = artists.Single(s => s.ArtistName == "Freddie Gibbs and Madlib")},
                new Album {
                    AlbumName = "For Now I Am Winter" ,
                    Artist = artists.Single(s => s.ArtistName == "Ólafur Arnalds")},
                new Album {
                    AlbumName = "Horse Stories" ,
                    Artist = artists.Single(s => s.ArtistName == "Dirty Three")},
                new Album {
                    AlbumName = "Singles" ,
                    Artist = artists.Single(s => s.ArtistName == "Future Islands")},
                new Album {
                    AlbumName = "Creatures of an Hour" ,
                    Artist = artists.Single(s => s.ArtistName == "Still Corners")},
                new Album {
                    AlbumName = "New History Warfare Vol. 3: To See More Light" ,
                    Artist = artists.Single(s => s.ArtistName == "Colin Stetson")},
                new Album {
                    AlbumName = "Knife Man" ,
                    Artist = artists.Single(s => s.ArtistName == "Andrew Jackson Jihad")},
                new Album {
                    AlbumName = "History Will Absolve Me" ,
                    Artist = artists.Single(s => s.ArtistName == "Billy Woods")},
                new Album {
                    AlbumName = "The Soul is the Arena" ,
                    Artist = artists.Single(s => s.ArtistName == "Mario Diaz De Leon")},
                new Album {
                    AlbumName = "Music for Ghosts" ,
                    Artist = artists.Single(s => s.ArtistName == "Sonic Area")},
                new Album {
                    AlbumName = "Mr Twin Sisten" ,
                    Artist = artists.Single(s => s.ArtistName == "Mr. Twin Sister")},
                new Album {
                    AlbumName = "Second Life Syndrome" ,
                    Artist = artists.Single(s => s.ArtistName == "Riverside")},
                new Album {
                    AlbumName = "Ompa til du dør" ,
                    Artist = artists.Single(s => s.ArtistName == "Kaizers Orchestra")},
                new Album {
                    AlbumName = "Demon" ,
                    Artist = artists.Single(s => s.ArtistName == "Gazpacho")},
                new Album {
                    AlbumName = "Konkurs" ,
                    Artist = artists.Single(s => s.ArtistName == "Lifelover")},
                new Album {
                    AlbumName = "Before the World was Big" ,
                    Artist = artists.Single(s => s.ArtistName == "Girlpool")},
                new Album {
                    AlbumName = "Life's a Riot with Spy vs. Spy" ,
                    Artist = artists.Single(s => s.ArtistName == "Billy Bragg")},
                new Album {
                    AlbumName = "Mark de Clive-Lowe" ,
                    Artist = artists.Single(s => s.ArtistName == "Church")},
                new Album {
                    AlbumName = "Juju" ,
                    Artist = artists.Single(s => s.ArtistName == "Soiouxsie and the Banshees")},
                new Album {
                    AlbumName = "Drop You Vivid Colors" ,
                    Artist = artists.Single(s => s.ArtistName == "Luminous Orange")},
                new Album {
                    AlbumName = "Xe" ,
                    Artist = artists.Single(s => s.ArtistName == "Zs")},
                new Album {
                    AlbumName = "Gamel" ,
                    Artist = artists.Single(s => s.ArtistName == "OOIOO")},
                new Album {
                    AlbumName = "Песня о безответной любви к Родине (trans: A Song About Unrequited Love for the Motherland)" ,
                    Artist = artists.Single(s => s.ArtistName == "Ноль (trans: Zero)")},
                new Album {
                    AlbumName = "Architecture of Loss" ,
                    Artist = artists.Single(s => s.ArtistName == "Valgeir Sigurðsson")},
                new Album {
                    AlbumName = "Ягудки" ,
                    Artist = artists.Single(s => s.ArtistName == "DakhaBrakha")},
                new Album {
                    AlbumName = "Silk and Salt Melodies" ,
                    Artist = artists.Single(s => s.ArtistName == "Louis Sclavis Quartet")},
                new Album {
                    AlbumName = "Prehistoricism" ,
                    Artist = artists.Single(s => s.ArtistName == "Intronaut")},
                new Album {
                    AlbumName = "Cold of Ages" ,
                    Artist = artists.Single(s => s.ArtistName == "Ash Borer")},
                new Album {
                    AlbumName = "Drop Out with the Barracudas" ,
                    Artist = artists.Single(s => s.ArtistName == "The Barracudas")},
                new Album {
                    AlbumName = "Beast Rest Forth Mouth" ,
                    Artist = artists.Single(s => s.ArtistName == "Bear in Heaven")},
                new Album {
                    AlbumName = "Sanitas" ,
                    Artist = artists.Single(s => s.ArtistName == "Stafrænn Hákon")},
                new Album {
                    AlbumName = "El Patio" ,
                    Artist = artists.Single(s => s.ArtistName == "Triana")},
                new Album {
                    AlbumName = "Ring" ,
                    Artist = artists.Single(s => s.ArtistName == "Glasser")},
                new Album {
                    AlbumName = "Spiderland" ,
                    Artist = artists.Single(s => s.ArtistName == "Slint")},
                new Album {
                    AlbumName = "1964/1985 Affinità-Divergenze fra il Compagno Togliatti e Noi – Del Conseguimento della Maggiore Età (trans: 1964/1985 Affinities-Divergences Between Comrade Togliatti and Us – Of the Coming of Age)" ,
                    Artist = artists.Single(s => s.ArtistName == "CCCP Fedeli alla linea (trans: [Something like] USSR True to the Course)")},
                new Album {
                    AlbumName = "Golevka" ,
                    Artist = artists.Single(s => s.ArtistName == "The Evpatoria Report")},
                new Album {
                    AlbumName = "The Current" ,
                    Artist = artists.Single(s => s.ArtistName == "Midday Veil")},
                new Album {
                    AlbumName = "Music for 18 Musicians" ,
                    Artist = artists.Single(s => s.ArtistName == "Steve Reich")},
                new Album {
                    AlbumName = "Out to Lunch!" ,
                    Artist = artists.Single(s => s.ArtistName == "Eric Dolphy")},
                new Album {
                    AlbumName = "Organ Music Not Vibraphone Like I'd Hoped" ,
                    Artist = artists.Single(s => s.ArtistName == "Moonface")},
                new Album {
                    AlbumName = "Give You the Ghost" ,
                    Artist = artists.Single(s => s.ArtistName == "Poliça")}
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
                    User = users.Single(s => s.RealName == "Phil"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Out From The Void"),
                    ContentsShort = "Short but strong for it"},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 0,
                    Album = albums.Single(s => s.AlbumName == "Hazyville"),
                    ContentsShort = "Kind of meanders about. Listen to Oneohtrix Point Never instead."},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "II"),
                    ContentsShort = "Rhythmically fascinating. Good noise, good groove, great drums."},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Addicted to Bad Ideas: Peter Lorre's Twentieth Century"),
                    ContentsShort = "Delightfully odd mix of punk, klezmer, pop, and jazz. Great brass section."},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "The Bronx"),
                    ContentsShort = "good guitar + good vocals. Thumbs up"},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Sword & Scorcery EP"),
                    ContentsShort = "Emotional Variety, strage without context(just for me probably)"},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "It's Album Time"),
                    ContentsShort = "Infectiously catchy"},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "Blackjazz"),
                    ContentsShort = "Fantastically uncategorizable, technical, great"},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "The Shape of Jazz to Come"),
                    ContentsShort = "Better than I expected."},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "American Football"),
                    ContentsShort = "Casually, pleasantly somber and mathy."},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 0,
                    Album = albums.Single(s => s.AlbumName == "The New Corn"),
                    ContentsShort = "Probably good if you like that kind of thing. I liked a couple. "},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "Klaus Nomi"),
                    ContentsShort = "Intentionally weird, but alright"},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "Misanthrope (S)"),
                    ContentsShort = "Amazing finish, hates you and everything you are"},
                new Review {
                    User = users.Single(s => s.RealName == "Nick"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "Infinity"),
                    ContentsShort = "Exelect blend of postrock/doom. "},
                new Review {
                    User = users.Single(s => s.RealName == "Nick"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "The Draft"),
                    ContentsShort = "Female fronted and a pleasent listen."},
                new Review {
                    User = users.Single(s => s.RealName == "Nick"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "D.I.Y.C.D."),
                    ContentsShort = "Brutal on both ends with droney parts in the middle."},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "The Vegetable Orchestra"),
                    ContentsShort = "Interesting. Decent for veggies. Worth one listen. "},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "A Place to Bury Strangers"),
                    ContentsShort = "Echo and The Bunnymen + MBV = A Place to Bury Strangers"},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Playboy & Playgirl"),
                    ContentsShort = "Super fun, poppy, enjoyable"},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 0,
                    Album = albums.Single(s => s.AlbumName == "Weather Systems"),
                    ContentsShort = "A talented band that makes terrible choices"},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "The Best of Bobby Womack - The Sould Years"),
                    ContentsShort = "Voice good, instrumentations meh, the medleys are solid"},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "צ'רצ'ילים (trans: Churchill's) "),
                    ContentsShort = "Fun. A few songs stand out. Average on the whole."},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Open Your Heart"),
                    ContentsShort = "A personal, creative trip with a noisy shoegaze theme."},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Surf"),
                    ContentsShort = "Fun indie rap stuffs, horns and great flow."},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Scheherazade and Other Stories"),
                    ContentsShort = "Well-crafted, pretentious as hell, very pretty"},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "The Remnant Mass"),
                    ContentsShort = "Hardcore with wacky time signatures "},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "White Men Are Black Men Too"),
                    ContentsShort = "At its best it's really good hip-pop, at its worst its sorta generic, decent pop."},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "Aizkolari"),
                    ContentsShort = "Fun and funky, but more concerned with political agenda than musical quality or uniqueness."},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "S/T and Our Loving is Hurting Us"),
                    ContentsShort = "Spooky Scary in the best way, will be listening to their other album as well"},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Earthbeat"),
                    ContentsShort = "Good Ambience, good vocals, good"},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Eternal Kingdom"),
                    ContentsShort = "Crushing"},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "METZ"),
                    ContentsShort = "Joe Strummer screaming in a shower in a good way."},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "Full on Dunes"),
                    ContentsShort = "Music is okay. Vocalist is terrible."},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "Walls"),
                    ContentsShort = "Percussion was good, but never grabbed my attention "},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Mean Love"),
                    ContentsShort = "Less interesting DFA stuff. A falsetto I couldnt get into"},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Moonlover"),
                    ContentsShort = "Full of emotion"},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "As the Stars"),
                    ContentsShort = "Vanilla, but in a good way"},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "The Long Goodbye"),
                    ContentsShort = "Soothing"},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Return to Annihilation"),
                    ContentsShort = "Incredibly atmospheric"},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Melting Sun"),
                    ContentsShort = "Basically heavier Have a Nice Life but not as good"},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "We Insist! - Freedom Suite Now"),
                    ContentsShort = "Moving, complex, relevant, essential"},
                new Review {
                    User = users.Single(s => s.RealName == "Nick"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "Witch Cult "),
                    ContentsShort = "Short birtst of brutality, but nothing too special."},
                new Review {
                    User = users.Single(s => s.RealName == "Nick"),
                    Rating = 0,
                    Album = albums.Single(s => s.AlbumName == "IV"),
                    ContentsShort = " That kid that would push you over then help you up only to drop you again"},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Илья (trans: Ilya)"),
                    ContentsShort = "Light prog, Russian Geddy Lee, delightfuly odd folk"},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Dageraad"),
                    ContentsShort = "Soothing, but a little unsettling"},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "Aratamemashite, Hajimemashite, Midori Desu"),
                    ContentsShort = "High energy, delightful, all over the place. Love the vocalist. "},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "Apex Predator - Easy Meat"),
                    ContentsShort = "Not relatable. Wish I liked this more."},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Thank Christ for the Bomb"),
                    ContentsShort = "Good, solid music, lyrics need work."},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "More Than Any Other Day"),
                    ContentsShort = "Pixies-esque, fun, strangely uplifting."},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "Ghetto Blaster"),
                    ContentsShort = "Kind of Grating, less interesting guitar than other punk from this month"},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "Epitaph"),
                    ContentsShort = "It's two hours of a jazz master doing his thing. Take a guess. "},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "Fucking Whore Society"),
                    ContentsShort = "Interesting, but definitely not actively engaging"},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "I'm Wide Awake, It's Morning"),
                    ContentsShort = "Really, really good. My favorite so far."},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "Migration"),
                    ContentsShort = "Good with surprising range."},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Spanish Dance Troupe"),
                    ContentsShort = "Sad, sweet. Good for a rainy day. Listen to the titular track."},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Satori"),
                    ContentsShort = "Amazing jam album"},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Epicus Doomicus Metallicus"),
                    ContentsShort = "Corny, but it works in spite of, not because of, it."},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "...And Watercycles"),
                    ContentsShort = "Cheesy titles, cool piano, loved parts of it, I think its worth a listen"},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "Warcry"),
                    ContentsShort = "Good instrumentation, nu metal vocals are a turn off"},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Drone Machines"),
                    ContentsShort = "Stellar drone and a solid emotion throughout "},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Ursus Americanus"),
                    ContentsShort = "Doomstep? "},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "The Ape of Naples"),
                    ContentsShort = "A triumph of its field."},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "Artificial Intelligence"),
                    ContentsShort = "Understand the influence, but nothing really caught my attention/moved enough"},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 0,
                    Album = albums.Single(s => s.AlbumName == "City of Gold"),
                    ContentsShort = "Rollercoasters between okay and terrible. Don't bother."},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Earth 2"),
                    ContentsShort = "Rumbly, but relatively diverse. Pretty good."},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Never Better"),
                    ContentsShort = "Good production under good, socially conscious rap."},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "Recitation"),
                    ContentsShort = "Phenomenal piece of post-rock, contrast is nearly perfect, AOTM shortlist"},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "My Feet Can't Fail Me Now"),
                    ContentsShort = "Fun, upbeat, jazzy. Listen if you like brass."},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "Head Over Heels"),
                    ContentsShort = "Sounded like a less poppy Bangals, I was mislead by reviews"},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Gnoia"),
                    ContentsShort = "Great vocals, good instrumentation, a little too self-indulgent."},
                new Review {
                    User = users.Single(s => s.RealName == "Nick"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Coffins On Io"),
                    ContentsShort = "mix of prog, electronic, post rock and jazz fusion with a general 80's vibe"},
                new Review {
                    User = users.Single(s => s.RealName == "Nick"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "Bath"),
                    ContentsShort = "extremely eclectic consisting of death metal, ambient, jazz, post rock, chamber music"},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Modal Soul"),
                    ContentsShort = "Well-done, but done before, the production was solid but it didn't take many risks"},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "何でも無い凶器 (Nan de mo nai kyouki)"),
                    ContentsShort = "Fast, shifting, super fun. I'll be listening to this a lot more."},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "アナタソナタ (Anata Sonata)"),
                    ContentsShort = "Not quite as impressive, still lots of fun."},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "Gipsy Project"),
                    ContentsShort = "Technically good, missing something. A bit derivative."},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "Disconnected"),
                    ContentsShort = "Heavy noise, brutal even, but its strength comes from its madness"},
                new Review {
                    User = users.Single(s => s.RealName == "Nick"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "The Painters Palette"),
                    ContentsShort = ""},
                new Review {
                    User = users.Single(s => s.RealName == "Nick"),
                    Rating = 0,
                    Album = albums.Single(s => s.AlbumName == "DNA On DNA"),
                    ContentsShort = ""},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Titan"),
                    ContentsShort = "Fundamentally sound, fun, excellently paced."},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Continent"),
                    ContentsShort = "Instrumental, dancey, fun, good"},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Songs About Fucking"),
                    ContentsShort = "Brutal, angry, outspoken. The embodiment of punk."},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "More Constant Than the Gods"),
                    ContentsShort = "Gentle doom for gentle doods "},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "Withdrawe, this sable Disclosure ere devot'd"),
                    ContentsShort = "I think I need to listen to it again. I didn't hate it, but I got less from it than I expected to."},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Drums of Passion"),
                    ContentsShort = "Really enjoyable."},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Through the trees"),
                    ContentsShort = "Good lyrics, sometimes dark, often too twangy for me"},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "人間 (Ningen)"),
                    ContentsShort = "Funky, angry Midori. Great bassist."},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Blood Ceremony"),
                    ContentsShort = "Spooky, nostalgic, but manages to stay unique (mostly because flute)."},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Frengers"),
                    ContentsShort = "A lot of fun, heartfelt without being twee"},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Чайник вина (trans: Teapot of Wine)"),
                    ContentsShort = "Surprisingly good. Folky with just the right amount of creepy."},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Intuit"),
                    ContentsShort = "Not remarkable indie "},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Buried"),
                    ContentsShort = "The walls of sound coalesced and acted as a blanket"},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "Deii"),
                    ContentsShort = "So very good. Listen to this."},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Neu!"),
                    ContentsShort = "pretty alright"},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "Tárrega/Narciso Yepes"),
                    ContentsShort = "Ecocative and virtuosic."},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "イリヤ (Ilya)"),
                    ContentsShort = "Crazy good blend of post rock, metal, and symphonic stuff. Listen if you like any of those."},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Revolutionary Vol. 2"),
                    ContentsShort = "Much better than expected. Deep shit. Eye opening."},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Winter Hymn Country Hymn Secret Hymn"),
                    ContentsShort = "Organic and danceable."},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "Octopus4"),
                    ContentsShort = "sort of interesting, not my thing"},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 0,
                    Album = albums.Single(s => s.AlbumName == "Omnia"),
                    ContentsShort = "Hard to listen to."},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Pelagial"),
                    ContentsShort = "A lot like progressive Mastodon stuff. Great instrumentation/screaming. Meh clean vox."},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "The Soft Pink Truth"),
                    ContentsShort = "Fun, edgy music that would scare your grandma."},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Hard Times for Dreamers"),
                    ContentsShort = "Pretty cool shoegaze... thats it"},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "With Promises of Death"),
                    ContentsShort = "Dark, unsettling, at times a little schlocky, but overall good"},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "The Cold Vein"),
                    ContentsShort = "Great production (duh), good rapping."},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 0,
                    Album = albums.Single(s => s.AlbumName == "Run the Jewels 2"),
                    ContentsShort = "Not as good as it was made out to be."},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "Roadburn"),
                    ContentsShort = "I wanted Doomjazz, goddammit. I don't know what it is, but I want it."},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "Silver Year"),
                    ContentsShort = "Do you like Perfect Pussy? Or noise punk? Or any kind of punk? Listen to this."},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "The Week that Was"),
                    ContentsShort = "It's a concept album, the music wasn't very interesting, maybe the lyrics are?"},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Kokning"),
                    ContentsShort = "Thinking man's space disco"},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Where You Go I Go Too"),
                    ContentsShort = "Clubs should play music like this"},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "You Are All I See"),
                    ContentsShort = "Listen to How to Dress Well or Autre Ne Veut"},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "When Life Comes to Death"),
                    ContentsShort = "Good black metal/punk crossover"},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "The Great Depression"),
                    ContentsShort = "Excellent. Best of folk, punk, and satiric lyrics."},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Satan, Sex and No Regrets"),
                    ContentsShort = "A midpoint between Dead Man's Bones and AJJ. Lots of fun. "},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "CLPPNG"),
                    ContentsShort = "Awesome, great lyrics, Interesting, experimental, arching."},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "From Parts Unknown"),
                    ContentsShort = "Imagine a universe where Converge is southern and has occasional clean vocal parts."},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "Long Season"),
                    ContentsShort = "Genuinely surprised this isn't a bigger deal"},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "War on Errorism"),
                    ContentsShort = "Pretty good. Very anti-Bush. Good, biting lyrics."},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "Pinata"),
                    ContentsShort = "Alright, A little to rough for me, I can see the appeal"},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "For Now I Am Winter"),
                    ContentsShort = "Beautiful, urgent, sweeping. Music to dream to."},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "Horse Stories"),
                    ContentsShort = "An interesting approach to the genre, but really boring."},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Singles"),
                    ContentsShort = "A little disappointing. The vocals and synth didn't do it for me."},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "Creatures of an Hour"),
                    ContentsShort = "I loved it, wonderful ambience, super effective, I'm a sucker for the genre"},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "New History Warfare Vol. 3: To See More Light"),
                    ContentsShort = "Subtly inorganic and interesting as hell."},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "Knife Man"),
                    ContentsShort = "Improves from the first song to the last...from bad to okay."},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "History Will Absolve Me"),
                    ContentsShort = "Reminiscent of Madvillainy in its diversity. Very good."},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "The Soul is the Arena"),
                    ContentsShort = "Complex and interesting, periodic glitch aesthetic in chamber music is cool"},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Music for Ghosts"),
                    ContentsShort = "Genre jumping and surprisingly easy to listen to."},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Mr Twin Sisten"),
                    ContentsShort = "Sounded like they really dig the 80s"},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Second Life Syndrome"),
                    ContentsShort = "A lot like Steven Wilson/Opeth. Good sound for this kind of band."},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Ompa til du dør"),
                    ContentsShort = "Excellent. Great brass section, good instrumentation. Beautifully discordant."},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "Demon"),
                    ContentsShort = "Ambitious and diverse, but it totally works."},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "Konkurs"),
                    ContentsShort = "Fairly basic for black metal. Keep waiting for something really interesting to happen."},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Before the World was Big"),
                    ContentsShort = "Seemed like pitchfork would love it, kinda sounded like the shaggs"},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "Life's a Riot with Spy vs. Spy"),
                    ContentsShort = "Simple. Beautiful. A man and his guitar (for the most part)."},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "Mark de Clive-Lowe"),
                    ContentsShort = "Varied and great."},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Juju"),
                    ContentsShort = "Rad, vocals took me a second, totally onboard with the instrumentals though"},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Drop You Vivid Colors"),
                    ContentsShort = "High quality, noisy shoegaze. Great guitar riffs."},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "Xe"),
                    ContentsShort = "Super good, hypnotic noise jazz. Fuck Buttons as heard in a fever dream. "},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "Gamel"),
                    ContentsShort = "Started off strong, but I got bored over time"},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Песня о безответной любви к Родине (trans: A Song About Unrequited Love for the Motherland)"),
                    ContentsShort = "Good fun. Not spectacular."},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "Architecture of Loss"),
                    ContentsShort = "Challenging, but not overly so."},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Ягудки"),
                    ContentsShort = "Really cool, way too much fun"},
                new Review {
                    User = users.Single(s => s.RealName == "Chris"),
                    Rating = 0,
                    Album = albums.Single(s => s.AlbumName == "Silk and Salt Melodies"),
                    ContentsShort = ""},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "Prehistoricism"),
                    ContentsShort = "Really, very good sludge. Hella good bassist. Listen to the last track if nothing else."},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Cold of Ages"),
                    ContentsShort = "Spends most of its budget being atmospheric, and the black metal is above average"},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Drop Out with the Barracudas"),
                    ContentsShort = "Fun summer sound. Surf rock sound with occasionally heavy lyrics."},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 1,
                    Album = albums.Single(s => s.AlbumName == "Beast Rest Forth Mouth"),
                    ContentsShort = "I can't do psychadelic, man. There's a bit of early Modest Mouse in there, though. "},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Sanitas"),
                    ContentsShort = "Early Coldplay, EITS type post rock. Good, but a bit meandering."},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "El Patio"),
                    ContentsShort = "Phenomenal. Prog rock and flamenco go surprisingly well together."},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "Ring"),
                    ContentsShort = "wonderful dream pop, great vocals cool varience, random horns?"},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Spiderland"),
                    ContentsShort = "Would have blown my mind in 1991, but 24 years later, its influence is still clear"},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "1964/1985 Affinità-Divergenze fra il Compagno Togliatti e Noi – Del Conseguimento della Maggiore Età (trans: 1964/1985 Affinities-Divergences Between Comrade Togliatti and Us – Of the Coming of Age)"),
                    ContentsShort = "Mostly very enjoyable. Unlike anything I'd heard before."},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "Golevka"),
                    ContentsShort = "Definitely AOTM contender. A great, spacey take on post rock. Blew me away."},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "The Current"),
                    ContentsShort = "Parts were cool, there wasn't enough going on."},
                new Review {
                    User = users.Single(s => s.RealName == "Joey"),
                    Rating = 3,
                    Album = albums.Single(s => s.AlbumName == "Music for 18 Musicians"),
                    ContentsShort = "Massive, unyielding, beautiful, influential. Special."},
                new Review {
                    User = users.Single(s => s.RealName == "Matt"),
                    Rating = 0,
                    Album = albums.Single(s => s.AlbumName == "Out to Lunch!"),
                    ContentsShort = "I'm not a big enough boy for big boy jazz"},
                new Review {
                    User = users.Single(s => s.RealName == "Polio"),
                    Rating = 2,
                    Album = albums.Single(s => s.AlbumName == "Organ Music Not Vibraphone Like I'd Hoped"),
                    ContentsShort = "Not really my thing, but enjoyable."},
                new Review {
                    User = users.Single(s => s.RealName == "Stephen"),
                Rating = 1,
                Album = albums.Single(s => s.AlbumName == "Give You the Ghost"),
                ContentsShort = "I don't really like autotune, nor did I like the ambience of this ambient album"}
            };

            artists.ForEach(s => context.Artists.AddOrUpdate(p => p.ArtistName, s));
            albums.ForEach(s => context.Albums.AddOrUpdate(p => p.AlbumName, s));
            reviews.ForEach(s => context.Reviews.AddOrUpdate(p => p.AlbumId, s));
            context.SaveChanges();

        }
    }
}
