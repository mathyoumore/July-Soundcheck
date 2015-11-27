class CreateAlbums < ActiveRecord::Migration
  def change
    create_table :albums do |t|
    #    t.band :band
        t.string :tracklist
        t.string :location
   #     t.review :review
        t.string :genre
        
      t.timestamps
    end
  end
end
