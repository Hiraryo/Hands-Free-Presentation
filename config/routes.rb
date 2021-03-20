Rails.application.routes.draw do
  get 'presentations/index'
  post 'presentations' => 'presentations#index'
  get 'presentations/show'
  get 'presentations/new'
  post 'presentations' => 'presentations#create'

  get 'slides/index'
  # http://0.0.0.0:3000/slides/show/1で1ページ目を表示するようにしたい
  # URLごとに変わる値はコロンを付けて表す。
  # :slidesというパラメーターをslidesコントローラーのshowで受け取る
  # :slidesには現在のページ番号が代入される
  get 'slides/show/:slides' => 'slides#show'

  # http://0.0.0.0:3000/slides/show/1にアクセスすると、
  # params[:slides] = '1'
  # という値が代入されて、
  # http://0.0.0.0:3000/slides/show/5にアクセスすると、
  # params[:slides] = '5'
  # という値が代入される。
  
end
