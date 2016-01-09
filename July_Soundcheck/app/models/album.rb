class Album < ActiveRecord::Base
  has_many :reviews
  belongs_to :artist
  accepts_nested_attributes_for :artist
  #validates_uniqueness_of :title

  def average_review
    ave = 0
    reviews.each do |r|
      ave = ave + r.rating
    end
    ave = ave / reviews.count unless reviews.count == 0
    return ave
  end

  def album_params
    params.require(:album).permit(:name,:artist)
  end

end
