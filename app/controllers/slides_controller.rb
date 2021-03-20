class SlidesController < ApplicationController
  def index
  end

  def show
    @user = User.find_by(:slides => params[:slides])
  end
end
