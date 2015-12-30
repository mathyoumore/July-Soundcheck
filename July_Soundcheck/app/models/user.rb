class User < ActiveRecord::Base
      has_many :reviews
      attr_accessible :email, :password, :password_confirmation
      validates_uniqueness_of :email
      has_secure_password
end
