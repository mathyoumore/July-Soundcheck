class ChangeNameToTitleInAlbum < ActiveRecord::Migration
  def change
    rename_column :albums, :name, :title
    end
end
