class PresentationsController < ApplicationController
  def index
    #プレゼンテーションモデルのデータを全て取得する。その後ビューで表示させればOK(app/views/presentations/index.html.erb)
    @presentations = Presentation.all
  end

  def show
  end

  def new
  end

  #スライドと声を登録する画面で「Create Presentation」を押すと、ここに飛ぶ
  def create
    @presentations = Presentation.new
    @presentations.filename = params[:presentation][:fine_name]
    @presentations.content = params[:presentation][:content]
    @presentations.save
    redirect_to '/presentations/index'
  end
end
