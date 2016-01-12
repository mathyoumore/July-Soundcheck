class User < ActiveRecord::Base
      has_many :reviews
      has_secure_password
      validates_uniqueness_of :email, :displayname

      def possessive_print
        displayname + ('s' == displayname[-1,1] ? "'" : "'s")
      end

end
