Rails.application.routes.draw do
  get 'presentations/index'
  get 'presentations/show'
  get 'presentations/new'
  post 'presentations' => 'presentations#create'
  get 'presentation/index'
  get 'presentation/show'
  get 'presentation/new'
  get 'slide/index'
  get 'slide/show'
  get 'slide/new'
  get 'slides/index'
  get 'slides/show/:slidepage' => 'slides#show'
  # For details on the DSL available within this file, see https://guides.rubyonrails.org/routing.html
end
