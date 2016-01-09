var artists = new Bloodhound({
  datumTokenizer: Bloodhound.tokenizers.obj.whitespace('name'),
  queryTokenizer: Bloodhound.tokenizers.whitespace,
  prefetch: '../artists.json'
});

var albums = new Bloodhound({
  datumTokenizer: Bloodhound.tokenizers.obj.whitespace('title'),
  queryTokenizer: Bloodhound.tokenizers.whitespace,
  prefetch: '../albums.json'
});

var reviews = new Bloodhound({
  datumTokenizer: Bloodhound.tokenizers.obj.whitespace('contents'),
  queryTokenizer: Bloodhound.tokenizers.whitespace,
  prefetch: '../reviews.json'
});

var users = new Bloodhound({
  datumTokenizer: Bloodhound.tokenizers.obj.whitespace('displayname'),
  queryTokenizer: Bloodhound.tokenizers.whitespace,
  prefetch: '../users.json'
});

$('li input[data-typeahead-global]').typeahead({
  highlight: true,
  hint: "Search albums and artists",
  minLength: 1,
  classNames: {
    menu: 'f-dropdown'
  }
},
{
  name: 'artists',
  display: 'name',
  source: artists,
  templates: {
    header: '<h5 class="artist-search">Artist</h5>'
  }
},
{
  name: 'albums',
  display: 'title',
  source: albums,
  templates: {
    header: '<h5 class="albums-search">Album</h5>'
  }
},
{
  name: 'reviews',
  display: 'contents',
  source: reviews,
  templates: {
    header: '<h5 class="albums-search">Review</h5>'
  }
},
{
  name: 'users',
  display: 'displayname',
  source: users,
  templates: {
    header: '<h5 class="user-search">User</h5>'
  }
}
);

function site_typeahead_global(el) {
  return $(el).typeahead({
    highlight: true,
    minLength: 1,
    classNames: {
      menu: 'f-dropdown'
    }
  },{
    name: 'artists',
    display: 'value',
    source: artists,
    templates: {
      header: '<h5 class="albums-search">Artist</h5>'
    }
  },
  {
    name: 'albums',
    display: 'title',
    source: albums,
    templates: {
      header: '<h5 class="albums-search">Album</h5>'
    }
  },
  {
    name: 'reviews',
    display: 'id',
    source: reviews,
    templates: {
      header: '<h5 class="albums-search">Review</h5>'
    }
  },
  {
    name: 'users',
    display: 'displayname',
    source: users,
    templates: {
      header: '<h5 class="user-search">User</h5>'
    }
  }
);
}

$('li input[data-typeahead-global]').each(function(index){
  //site_typeahead_global(this);
});
