// Example 1
List<Student> Sort = (from ar in Ar orderby ar.Name,
        ar.Count select ar)
    .ToList<Student>();

// Example 2
Pet[] pets = {
    new Pet { Name = "Barley", Age = 8 },
    new Pet { Name = "Boots", Age = 4 },
    new Pet { Name = "Whiskers", Age = 1 }
};

IEnumerable<Pet> query = pets.OrderBy(pet => pet.Age);

// Example 3
string[] words = { "the", "quick", "brown", "fox", "jumps" };

IEnumerable<string> query = from word in words
orderby word.Length
select word;

// Example 4

IEnumerable<string> query = from word in words
orderby word.Substring(0, 1)descending
select word;

// Example 5

IEnumerable<string> query = from word in words
orderby word.Length, word.Substring(0, 1)
select word;

List<string> list = new List<string>();

// Example 6

string[] words = { "mississippi", "indus", "danube", "fnileox" };

var lengths = from element in list
orderby element.Length
select element;

/*
Results:

nile
indus
danube
mississippi
*/