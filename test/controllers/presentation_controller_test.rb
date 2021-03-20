require "test_helper"

class PresentationControllerTest < ActionDispatch::IntegrationTest
  test "should get index" do
    get presentation_index_url
    assert_response :success
  end

  test "should get show" do
    get presentation_show_url
    assert_response :success
  end

  test "should get new" do
    get presentation_new_url
    assert_response :success
  end
end
