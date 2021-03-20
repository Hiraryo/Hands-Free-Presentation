class SlidesController < ApplicationController
  def index
  end

  def show
    #ページ番号で画面を切り替える
    @user = User.find_by(:slides => params[:slides])
  end
end
