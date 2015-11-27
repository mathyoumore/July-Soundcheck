class Review < ActiveRecord::Base
    belongs_to :user
    has_one :band
    has_one :album
    
end
