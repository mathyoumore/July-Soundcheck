class AddContentsAndRatingToReviews < ActiveRecord::Migration
  def change
    change_table :reviews do |t|
      t.string :contents, null: false, default: ""
      t.integer :rating, null: false, default: 0, limit: 1, index: true
    end
    add_column :users, :password_digesst, :string, null:false, default: ""
    remove_column :users, :password

    add_reference :reviews, :artist, index: true, foreign_key: true
    add_reference :reviews, :album, index: true, foreign_key: true
    add_reference :reviews, :user, index: true, foreign_key: true
    add_reference :albums, :artist, index: true, foreign_key: true
  end
end
