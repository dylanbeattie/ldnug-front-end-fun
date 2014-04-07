(function() {
  var x;

  x = 1;

  say(x)(function() {
    return alert("CoffeeScript says '" + x + "'");
  });

}).call(this);
