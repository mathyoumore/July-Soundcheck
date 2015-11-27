class CreateUsergroups < ActiveRecord::Migration
  def change
    create_table :usergroups do |t|
        t.string :name
   #     t.user :members
    #    t.review :reviews
        
      t.timestamps
    end
  end
end
