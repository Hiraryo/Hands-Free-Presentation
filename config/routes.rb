Rails.application.routes.draw do
  get 'slides/index'
  get 'slides/show/:slidepage' => 'slides#show'
  # For details on the DSL available within this file, see https://guides.rubyonrails.org/routing.html
end
