class Review < ActiveRecord::Base
  belongs_to :user
  belongs_to :album
  has_one :artist, through: :album
  accepts_nested_attributes_for :album
  validates :album, :contents, :rating, presence: true
end
