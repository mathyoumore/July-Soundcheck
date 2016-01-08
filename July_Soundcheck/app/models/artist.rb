class Artist < ActiveRecord::Base
  has_many :albums
#  validates_uniqueness_of :name

  def average_review
    ave = 0
    review_count = 0
    albums.each do |a|
      a.reviews.each do |r|
        ave = ave + r.rating
        review_count += 1.0
      end
    end
    ave = ave / review_count unless review_count < 1
    ave.round(2)
  end

  def review_count
    review_count = 0
    albums.each do |a|
      a.reviews.each do |r|
        review_count += 1
      end
    end
    review_count
  end

  #This doesn't work yet 1/7
  def best_album
    best_album = albums[0]
    best_album_rating = -1
    review_count = 0
    review_rating_average = 0
    albums.each do |a|
      a.reviews.each do |r|
        review_rating_average += r.rating
        review_count += 1
      end
      review_rating_average /= review_count unless review_count == 0
      if best_album_rating < review_rating_average
        best_album = a[0]
        best_album_rating = review_rating_average
      end
      review_album_rating = 0
      review_count = 0
    best_album
    end
  end
end
