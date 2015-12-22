require 'csv'


def AddArtist(row)
	return "new Artist { ArtistName = \"#{row[0]}\""
end

def AddAlbum(row)
	return "new Album { 
	AlbumName = \"#{row[1]}\" , 
	Artist = artists.Single(s => s.ArtistName == \"#{row[0]}\")"
end

def AddReview(row)
	#puts row[7]
	return "new Review { 	
	User = users.Single(s => s.RealName == \"#{row[5]}\"), 
	Rating = #{if row[7].nil? then 0 else row[7][0] end}, 
	Album = albums.Single(s => s.AlbumName == \"#{row[1]}\"),
	ContentsShort = \"#{row[4]}\""
end

csv = CSV.read(ARGV[0]).to_a
artists = "var artists = new List<Artist>\n{\n"
albums = "var albums = new List<Album>\n{\n"
reviews = "var reviews = new List<Review>\n{\n"

for r in 1...csv.length
	if r < csv.length - 1	
		artists = artists + AddArtist(csv[r]) + "},\n"
		albums = albums + AddAlbum(csv[r]) + "},\n"
		reviews = reviews + AddReview(csv[r]) +"},\n"
	else 
		artists = artists + AddArtist(csv[r]) + "}\n};"
		albums = albums + AddAlbum(csv[r]) + "}\n};"
		reviews = reviews + AddReview(csv[r]) +"}\n};"
	end
	
end

artists + "\n};"
albums + "\n};"
reviews + "\n};"

fout = artists + "\n" + albums + "\n" + reviews +"\n\n"

fout += "artists.ForEach(s => context.Artists.AddOrUpdate(p => p.ArtistName, s));\n"
fout += "albums.ForEach(s => context.Albums.AddOrUpdate(p => p.AlbumName, s));\n"
fout += "reviews.ForEach(s => context.Reviews.AddOrUpdate(p => p.AlbumId, s));\n"
fout += "context.SaveChanges();\n"

File.open("JSCParsed.txt", 'w') { |file| file.write(fout) }




