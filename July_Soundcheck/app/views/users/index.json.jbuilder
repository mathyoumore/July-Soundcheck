json.array!(@users) do |user|
  json.extract! user, :id, :displayname, :email, :password
  json.url user_url(user, format: :json)
end
