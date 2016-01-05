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

users = Hash.new(0)

users["Matt"] = User.create(displayname: "mathyoumore", email: "literatehullmonk@gmail.com", password_digest: "test")
users["Phil"] = User.create(displayname: "Philstone", email: "test1@test.com",password_digest: "test")
users["Joey"] = User.create(displayname: "Jrade", email: "test2@test.com",password_digest: "test")
users["Chris"] = User.create(displayname: "Crade", email: "test3@test.com",password_digest: "test")
users["Polio"] = User.create(displayname: "Polio", email: "test4@test.com",password_digest: "test")
users["Stephen"] = User.create(displayname: "Turkey", email: "test5@test.com",password_digest: "test")
users["Turk"] = users["Stephen"]
users["Nick"] = User.create(displayname: "who", email: "test6@test.com",password_digest: "test")
users["Zach"] = User.create(displayname: "waterbuffalo", email: "test7@test.com",password_digest: "test")
users["Mike"] = User.create(displayname: "whoismike", email: "test8@test.com",password_digest: "test")

for r in 1...csv.length
  art = Artist.find_or_create_by(name: csv[r][0])
  alb = Album.find_or_create_by(title: csv[r][1], artist: art)
	Review.create(album: alb, user: users[csv[r][5]], contents: csv[r][4], rating: if csv[r][7].nil? then 0 else csv[r][7] end)
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
