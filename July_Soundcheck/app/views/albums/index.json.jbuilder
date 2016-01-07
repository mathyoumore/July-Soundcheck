json.array!(@albums) do |album|
  #json.id album.id
  #json.artist album.artist.name
  json.extract! album, :id, :title, :artist
  json.url album_url(album, format: :json)
end
