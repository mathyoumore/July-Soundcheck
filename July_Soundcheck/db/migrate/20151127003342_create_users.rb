class CreateUsers < ActiveRecord::Migration
  def change
    create_table :users do |t|
       # t.review :reviews
        t.string :real_name
        t.string :user_name
        t.string :password
        t.string :email
        t.date :join_date
      #  t.group :groups
        t.string :twitter_name
        
      t.timestamps
    end
  end
end
