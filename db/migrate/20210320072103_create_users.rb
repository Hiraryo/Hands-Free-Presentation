class CreateUsers < ActiveRecord::Migration[6.1]
  def change
    create_table :users do |t|
      t.string :slides
      t.string :slideMasters
      t.string :slideLayouts
      t.string :theme
      t.string :notesMaster
      t.string :notesSlides

      t.timestamps
    end
  end
end
