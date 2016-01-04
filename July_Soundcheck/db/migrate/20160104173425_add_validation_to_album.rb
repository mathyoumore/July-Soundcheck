class AddValidationToAlbum < ActiveRecord::Migration
  def change
    remove_column :albums, :title
    add_column :albums, :title, :string, null:false, default: ""
  end
end
