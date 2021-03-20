class SlidesController < ApplicationController
  def index
  end

  def show
    @user = Hash.new
    @user[:slides] = '5'
    @user[:slideMasters] = 'slideMasters'
  end
end
