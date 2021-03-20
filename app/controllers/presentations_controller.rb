class PresentationsController < ApplicationController
  def index
  end

  def show
  end

  def new
  end

  #スライドと声を登録する画面で「Create Presentation」を押すと、ここに飛ぶ
  def creates
    @presentation = Presentation.new
    @presentation.title = params[:presentation][:title]
    @presentation.content = params[:presentation][:content]
    @presentation.save
    redirect_to '/presentations/index'
  end
end
