string[] customers = {
     "Arianne",
     "Bill",
     "David",
     "Manuel",
     "Veronic",
     "Asia",
     "Daniel",
     "Renate",
     "Vincent",
     "Alexia",
     "Daisy"
};

// Example 1

var nameStartsWith =
     from name in customers
where(name.StartsWith("A"))
select name;

// Example 2

var nameEquals =
     from name in customers
where(name == "Bill")
select name;