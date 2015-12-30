class Album < ActiveRecord::Base
  has_many :reviews
  belongs_to :artist
  accepts_nested_attributes_for :artist

  private
  def album_params
    params.require(:album).permit(:name,:artist)
  end
end
