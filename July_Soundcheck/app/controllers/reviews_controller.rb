class ReviewsController < ApplicationController
  before_action :set_review, only: [:show, :edit, :update, :destroy]
  # GET /reviews
  # GET /reviews.json
  helper_method :sort_column, :sort_direction
  def index
    @reviews = Review.joins(:album => :artist).joins(:user).order(sort_column + " " + sort_direction).page(params[:page]).per_page(20)
  end

  # GET /reviews/1
  # GET /reviews/1.json
  def show
  end

  # GET /reviews/new
  def new
    @review = Review.new(album:Album.new(artist:Artist.new))
  end

  # GET /reviews/1/edit
  def edit
  end

  # POST /reviews
  # POST /reviews.json
  def create
    @params = review_params.merge(user: current_user)
  #  @params[:artist_attributes] = Artist.find_or_create_by(name: @params[:album_attributes][:artist_attributes][:name]).artist_params
    @review = Review.new
    @review.artist = Artist.find_or_create_by(name: @params[:album_attributes][:artist_attributes][:name])
    @review.album = Album.find_or_create_by(title: @params[:album_attributes][:title], artist: @review.artist)
    @review.user = @params[:user]
    @review.rating = @params[:rating]
    @review.contents = @params[:contents]
    # THIS IS TERRIBLE!

    respond_to do |format|
      if @review.save
        format.html { redirect_to reviews_path,
          notice: "Review was successfully created for #{@params[:album_attributes][:title]} by #{@params[:album_attributes][:artist_attributes][:name]}" }
        format.json { render :show, status: :created, location: @review }
      else
        format.html { render :new }
        format.json { render json: @review.errors, status: :unprocessable_entity }
      end
    end
  end

  # PATCH/PUT /reviews/1
  # PATCH/PUT /reviews/1.json
  def update
    respond_to do |format|
      if @review.update(review_params)
        format.html { redirect_to @review, notice: 'Review was successfully updated.' }
        format.json { render :show, status: :ok, location: @review }
      else
        format.html { render :edit }
        format.json { render json: @review.errors, status: :unprocessable_entity }
      end
    end
  end

  # DELETE /reviews/1
  # DELETE /reviews/1.json
  def destroy
    @review.destroy
    respond_to do |format|
      format.html { redirect_to reviews_url, notice: 'Review was successfully destroyed.' }
      format.json { head :no_content }
    end
  end

  private

  def sort_column
    params[:sort] || "name"
  end

  private

  def sort_direction
    params[:direction] || "asc"
  end

  private
    # Use callbacks to share common setup or constraints between actions.
    def set_review
      @review = Review.find(params[:id])
    end

    # Never trust parameters from the scary internet, only allow the white list through.
    def review_params
        params.require(:review).permit(:contents, :rating,
        user_attributes:[:displayname],
        album_attributes:[:title, artist_attributes: [:name]])
    end
end
