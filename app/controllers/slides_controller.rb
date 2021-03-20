class SlidesController < ApplicationController
  def index
  end

  def show
    @user = Hash.new
    if params[:slidepage] == '1'
      @user[:name] = 'ryota'
      @user[:username] = 'hirai'
      @user[:location] = 'Osaka,Japan'
      @user[:about] = 'Nice'
    elsif params[:slidepage] == '2'
      @user[:name] = 'tanaka'
      @user[:username] = 'yamada'
      @user[:location] = 'Tokyo,Japan'
      @user[:about] = 'good'
    end
  end
end
