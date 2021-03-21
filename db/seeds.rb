# This file should contain all the record creation needed to seed the database with its default values.
# The data can then be loaded with the bin/rails db:seed command (or created alongside the database with db:setup).
#
# Examples:
#
#   movies = Movie.create([{ name: 'Star Wars' }, { name: 'Lord of the Rings' }])
#   Character.create(name: 'Luke', movie: movies.first)

@user = User.new
@user.slides = '1'
@user.slideMasters = 'slideMasters'
@user.slideLayouts = 'slideLayouts'
@user.theme = 'theme'
@user.notesMaster = 'notesMaster'
@user.notesSlides = 'notesSlides'
@user.save


@user = User.new
@user.slides = '2'
@user.slideMasters = 'Next_slideMasters'
@user.slideLayouts = 'Next_slideLayouts'
@user.theme = 'Next_theme'
@user.notesMaster = 'Next_notesMaster'
@user.notesSlides = 'Next_notesSlides'
@user.save