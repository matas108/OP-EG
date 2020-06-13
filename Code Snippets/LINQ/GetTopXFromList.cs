int amount = 0;

List<Student> students;

var list = (from x in students where x.AverageGrade > 7 &&
    x.ModuleCount == 5 orderby x.AverageGrade select x).Take(amount);