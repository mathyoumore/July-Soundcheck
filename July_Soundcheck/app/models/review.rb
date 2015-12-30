class Review < ActiveRecord::Base
  belongs_to :user
  has_one :album
  accepts_nested_attributes_for :artist, :album

end
