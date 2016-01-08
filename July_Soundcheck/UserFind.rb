require 'csv'

# Finds users from the CSV because nil error are irritating

csv = CSV.read("JSCData.csv").to_a
users = Hash.new(0)

for r in 1...csv.length
  users[csv[r][5]] += 1
end

users.each do |w,c|
  puts "#{w} ...... #{c} reviews"
end
