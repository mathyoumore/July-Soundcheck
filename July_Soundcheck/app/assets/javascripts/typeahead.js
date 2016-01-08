$(document).ready(function(){
  var sources = {
    get: function(name) {
      if(name == null) {
        name = '';
      }
      var set = null;
      name = name.split(':');
      var id = name[1];
      name = name[0];

      switch (name) {
        case('artists'):
          set = this.artists;
          break;
        case('albums'):
          set =  this.albums;
          break;
        default:
          set = this.default;
          break;
      }
      set.initialize();
      return set;
    },
    default: new Bloodhound({
      datumTokenizer: Bloodhound.tokenizers.whitespace,
      queryTokenizer: Bloodhound.tokenizers.whitespace,
      local: []
    }),
    albums: new Bloodhound({
      datumTokenizer: Bloodhound.tokenizers.obj.whitespace('title'),
      queryTokenizer: Bloodhound.tokenizers.whitespace,
      prefetch: {
          url: '../albums.json'
        }
    }),
    users: new Bloodhound({
      datumTokenizer: Bloodhound.tokenizers.obj.whitespace('displayname'),
      queryTokenizer: Bloodhound.tokenizers.whitespace,
      prefetch: {
          url: '../users.json'
        }
    }),
    artists: new Bloodhound({
      datumTokenizer: Bloodhound.tokenizers.obj.whitespace('name'),
      queryTokenizer: Bloodhound.tokenizers.whitespace,
      prefetch: {
          url: '../artists.json'
        }
    })
  };

  function site_typeahead(el) {
    return $(el).typeahead({
      highlight: $(el).data('highlight'),
      hint: $(el).data('hint'),
      minLength: $(el).data('minLength'),
      classNames: {
        menu: 'f-dropdown'
      }
    },{
      displayKey: 'name',
      name: 'my-dataset',
      source: sources.get($(el).data('source'))
    });
  }

  // Find all inputs with the data-typeahead attribute
  $('input[data-typeahead]').each(function(index){
    site_typeahead(this);
  });

  // $('.twitter-typeahead').each(function(index){
  //   $(this).find("input[data-source='artists']").parent().on("typeahead:autocomplete", function(event, obj){
  //     console.log(obj);
  //     $(this).siblings('.twitter-typeahead').each(function(index){
  //       if($(this).find('input.tt-input').attr('name').indexOf('title') >= 0) {
  //         base_scope = $(this).parent();
  //         $(this).find('input[data-typeahead]').typeahead('destroy');
  //         base_input = base_scope.find('> input[data-typeahead]');
  //         console.log(base_input.data());
  //         base_input.data('source','album:id');
  //         console.log(base_input.data());
  //         site_typeahead(base_input);
  //       }
  //     });
  //   });
  // });
});
