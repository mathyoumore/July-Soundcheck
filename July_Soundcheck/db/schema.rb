# encoding: UTF-8
# This file is auto-generated from the current state of the database. Instead
# of editing this file, please use the migrations feature of Active Record to
# incrementally modify your database, and then regenerate this schema definition.
#
# Note that this schema.rb definition is the authoritative source for your
# database schema. If you need to create the application database on another
# system, you should be using db:schema:load, not running all the migrations
# from scratch. The latter is a flawed and unsustainable approach (the more migrations
# you'll amass, the slower it'll run and the greater likelihood for issues).
#
# It's strongly recommended that you check this file into your version control system.

ActiveRecord::Schema.define(version: 20151127011948) do

  create_table "albums", force: true do |t|
    t.string   "tracklist"
    t.string   "location"
    t.string   "genre"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "bands", force: true do |t|
    t.string   "bio"
    t.string   "genres"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "reviews", force: true do |t|
    t.date     "date"
    t.string   "link_to_review"
    t.string   "rating"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "usergroups", force: true do |t|
    t.string   "name"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "users", force: true do |t|
    t.string   "real_name"
    t.string   "user_name"
    t.string   "password"
    t.string   "email"
    t.date     "join_date"
    t.string   "twitter_name"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

end
