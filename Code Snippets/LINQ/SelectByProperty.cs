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

var nameStartsWith =
     from name in customers
where(name.StartsWith("A"))
select name;

var nameEquals =
     from name in customers
where(name == "Bill")
select name;