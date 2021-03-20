require "test_helper"

class SlideControllerTest < ActionDispatch::IntegrationTest
  test "should get index" do
    get slide_index_url
    assert_response :success
  end

  test "should get show" do
    get slide_show_url
    assert_response :success
  end

  test "should get new" do
    get slide_new_url
    assert_response :success
  end
end
