class Artist < ActiveRecord::Base
  has_many :albums
#  validates_uniqueness_of :name

  def average_review
    ave = 0.0
    count = review_count {|r| ave += r.rating}
    ave = ave / count unless count < 1
    ave.round(2)
  end

  def review_count
    count = 0
    albums.each do |a|
      a.reviews.each do |r|
        count += 1
        yield r if block_given?
      end
    end
    count
  end

  #This doesn't work yet 1/7
  def best_album
    best = albums[0]
    best_review = best.average_review
    albums.each do |a|
      if a.average_review > best_review
        best_review = a.average_review
        best = a
      end
    end
    best
  end
end
