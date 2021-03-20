class SlidesController < ApplicationController
  def index
  end

  def show
    # ページ番号で画面を切り替える
    # config/routes.rbから来て
    # ユーザーモデルに入っているデータの中で、スライドのページが1のスライド情報を探すには User.find_by(:slides => '1')
    # スライドのマスターデータでslideMastersという情報を探すには、User.find_by(:slideMasters => 'slideMasters')とすればいい
    @user = User.find_by(:slides => params[:slides])
  end
end
