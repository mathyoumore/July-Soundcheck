# This file should contain all the record creation needed to seed the database with its default values.
# The data can then be loaded with the rake db:seed (or created alongside the db with db:setup).
#
# Examples:
#
#   cities = City.create([{ name: 'Chicago' }, { name: 'Copenhagen' }])
#   Mayor.create(name: 'Emanuel', city: cities.first)
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

csv = CSV.read("JSCData.csv").to_a

User.create(displayname: "mathyoumore", email: "literatehullmonk@gmail.com", password_digest: "test")
User.create(displayname: "Philstone", email: "test1@test.com",password_digest: "test")
User.create(displayname: "Jrade", email: "test2@test.com",password_digest: "test")
User.create(displayname: "Crade", email: "test3@test.com",password_digest: "test")
User.create(displayname: "Polio", email: "test4@test.com",password_digest: "test")
User.create(displayname: "Turkey", email: "test5@test.com",password_digest: "test")
User.create(displayname: "waterbuffalo", email: "test6@test.com",password_digest: "test")

for r in 1...csv.length
  art = Artist.create(name: csv[r][0])
  alb = Album.create(title: csv[r][1], artist: art)

end

#artists + "\n};"
#albums + "\n};"
#reviews + "\n};"

#fout = artists + "\n" + albums + "\n" + reviews +"\n\n"

#fout += "artists.ForEach(s => context.Artists.AddOrUpdate(p => p.ArtistName, s));\n"
#fout += "albums.ForEach(s => context.Albums.AddOrUpdate(p => p.AlbumName, s));\n"
#fout += "reviews.ForEach(s => context.Reviews.AddOrUpdate(p => p.AlbumId, s));\n"
#fout += "context.SaveChanges();\n"

#File.open("JSCParsed.txt", 'w') { |file| file.write(fout) }
