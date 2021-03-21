require "test_helper"

class Presentations2ControllerTest < ActionDispatch::IntegrationTest
  test "should get index" do
    get presentations2_index_url
    assert_response :success
  end

  test "should get show" do
    get presentations2_show_url
    assert_response :success
  end
end
