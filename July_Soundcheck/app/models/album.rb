class Album < ActiveRecord::Base
  has_many :reviews
  belongs_to :artist
  accepts_nested_attributes_for :artist
  #validates_uniqueness_of :title

  def average_review
    ave = 0
    each_review { |r| ave += r.rating}
    ave /= reviews.count
    ave
  end

  def highest_review
    high = 0
    each_review { |r| high = r.rating if r.rating > high }
    high
  end

  def lowest_review
    low = 6
    each_review { |r| low = r.rating if r.rating < low }
    low
  end

  def each_review
    reviews.each do |r|
      yield r
    end
  end


  def album_params
    params.require(:album).permit(:name,:artist)
  end

end
