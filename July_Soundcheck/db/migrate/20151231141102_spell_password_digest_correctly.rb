class SpellPasswordDigestCorrectly < ActiveRecord::Migration
  def change
    remove_column :users, :password_digesst
    add_column :users, :password_digest, :string, null:false, default: ""
  end
end
