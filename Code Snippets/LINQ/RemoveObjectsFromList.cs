// Creating object of list  
List<string> stringlist = new List<string>
{
    "a",
    "b",
    "c",
    "d",
    "e",
};

// Deleting item by remove function by passing object  
string a = stringlist.FirstOrDefault(st => st == "a");
stringlist.Remove(a);

// Deleting item by creating object internally by filtering  
stringlist.Remove(stringlist.FirstOrDefault(st => st == "a"));

// Remove items from list by passing filters  
stringlist.RemoveAll(st => st == "a");

// Remove items by passing item index  
stringlist.RemoveAt(0);

// Remove range of element from list by passing start index and number of elements to delete  
stringlist.RemoveRange(0, 2);