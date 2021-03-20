class SlidesController < ApplicationController
  def index
  end

  def show
    if params[:slides] == '5'
      @user = User.find_by(:slides => '5')
    elsif params[:slides] == '1'
      @user = User.find_by(:slides => '1')
    end
  end
end
