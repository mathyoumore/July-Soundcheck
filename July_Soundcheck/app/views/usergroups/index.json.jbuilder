json.array!(@usergroups) do |usergroup|
  json.extract! usergroup, :id
  json.url usergroup_url(usergroup, format: :json)
end
