class PresentationsController < ApplicationController
  def index
    #プレゼンテーションモデルのデータを全て取得する。その後ビューで表示させればOK(app/views/presentations/index.html.erb)
    @presentations = Presentation.all
  end

  def show
    # ページ番号で画面を切り替える
    # config/routes.rbから来て
    # ユーザーモデルに入っているデータの中で、スライドのページが1のスライド情報を探すには User.find_by(:slides => '1')
    # スライドのマスターデータでslideMastersという情報を探すには、User.find_by(:slideMasters => 'slideMasters')とすればいい
    @user = User.find_by(:slides => params[:slides])
  end

  def new
  end

  #スライドと声を登録する画面で「Create Presentation」を押すと、ここに飛ぶ
  def create
    @presentations = Presentation.new
    @presentations.title = params[:presentation][:title]
    @presentations.content = params[:presentation][:content]
    @presentations.save
    # プレゼン？登録後は登録したデータの一覧を表示するページへリダイレクトする。
    redirect_to '/presentations/index'
  end
end
