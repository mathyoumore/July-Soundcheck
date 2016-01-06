$(document).ready(function(){
  var states = ['Alabama', 'Alaska', 'Arizona', 'Arkansas', 'California',
    'Colorado', 'Connecticut', 'Delaware', 'Florida', 'Georgia', 'Hawaii',
    'Idaho', 'Illinois', 'Indiana', 'Iowa', 'Kansas', 'Kentucky', 'Louisiana',
    'Maine', 'Maryland', 'Massachusetts', 'Michigan', 'Minnesota',
    'Mississippi', 'Missouri', 'Montana', 'Nebraska', 'Nevada', 'New Hampshire',
    'New Jersey', 'New Mexico', 'New York', 'North Carolina', 'North Dakota',
    'Ohio', 'Oklahoma', 'Oregon', 'Pennsylvania', 'Rhode Island',
    'South Carolina', 'South Dakota', 'Tennessee', 'Texas', 'Utah', 'Vermont',
    'Virginia', 'Washington', 'West Virginia', 'Wisconsin', 'Wyoming'
  ];

  var sources = {
    get: function(name) {
      var set = [];
      
      if(name == 'names') {
        set = this.names;
      } else {
        set =  this.states;
      }
      set.initialize();
      return set;
    },
    states: new Bloodhound({
      datumTokenizer: Bloodhound.tokenizers.whitespace,
      queryTokenizer: Bloodhound.tokenizers.whitespace,
      local: states
    }),
    names: new Bloodhound({
      datumTokenizer: Bloodhound.tokenizers.obj.whitespace('name'),
      queryTokenizer: Bloodhound.tokenizers.whitespace,
      prefetch: {
          url: '../artists.json'
        }
    })

  };

  // Find all inputs with the data-typeahead attribute
  $('input[data-typeahead]').each(function(index){
    $(this).typeahead({
      highlight: $(this).data('highlight'),
      hint: $(this).data('hint'),
      minLength: $(this).data('minLength')
    },{
      displayKey: 'name',
      name: 'my-dataset',
      source: sources.get($(this).data('source'))
    });
  });
});
