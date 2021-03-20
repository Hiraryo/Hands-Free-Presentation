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
    #accepted_format = [".mp3"]
    #if !accepted_format.include? File.extname("ここにファイルネーム")
    #    #指定した拡張子じゃない時の処理をここに書く
    #    return
    #end
    @presentations = Presentation.new
    #@presentations.fine_name = params[:presentation][:fine_name]
    @presentations.title = params[:presentation][:title]
    @presentations.content = params[:presentation][:content]
    @presentations.save
    # プレゼン？登録後は登録したデータの一覧を表示するページへリダイレクトする。
    redirect_to '/presentations/index'
  end
end
