help:
    @echo 'clean-branches -- Remove merged branches'
    @echo 'setup-rails -- setup rails environment'
clean-branches:
    git branch --merged | grep -v '^\*' | grep -v main | xargs git branch -d
    git fetch --prune

setup-rails:
    cp -f ./config/database.yml.tmp ./config/database.yml ;
    cp -f ./config/secrets.yml.tmp  ./config/secrets.yml ;
    bundle install --path vendor/bundle
    bundle exec rake db:create
    bundle exec rake db:migrate
    bundle exec rake db:seed
