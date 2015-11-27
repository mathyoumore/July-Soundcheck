class CreateBands < ActiveRecord::Migration
  def change
    create_table :bands do |t|
        t.string :bio
  #      t.album :albums
  #      t.band :sounds_like
        t.string :genres
      t.timestamps
    end
  end
end
