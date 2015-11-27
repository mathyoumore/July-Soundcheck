class CreateReviews < ActiveRecord::Migration
  def change
    create_table :reviews do |t|
     #   t.band :band
    #    t.album :album
     #   t.user :user
        t.date :date
        t.string :link_to_review
        t.string :rating

      t.timestamps
    end
  end
end
