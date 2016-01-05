class Review < ActiveRecord::Base
  belongs_to :user
  belongs_to :album
  has_one :artist, through: :album
  accepts_nested_attributes_for :album
  validates :album, :contents, :rating, presence: true
end

=begin
Artist - dropdown search : typeahed with forced "create new" option
Album - dropdown search : typeahead, if artist id was identified find their albums
Contents - Spellcheck and markdown: redcarpet
Rating - sliding scale, handled as integer
=end
