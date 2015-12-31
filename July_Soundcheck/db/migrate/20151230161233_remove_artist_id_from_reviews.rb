class RemoveArtistIdFromReviews < ActiveRecord::Migration
  def change
    remove_column :reviews, :artist_id
  end
end
