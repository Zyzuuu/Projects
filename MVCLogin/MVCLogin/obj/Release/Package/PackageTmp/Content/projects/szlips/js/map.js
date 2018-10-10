$(document).ready(function(){
  $('#map').jMapping({
    category_icon_options: {
      'restaurant': {primaryColor: '#E8413A', cornerColor: '#EBEBEB'},
      'museum': {primaryColor: '#465AE0', cornerColor: '#EBEBEB'},
      'default': {primaryColor: '#7CDF65'}
    }
  });
});