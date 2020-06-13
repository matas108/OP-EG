int amount = 1;

List<Student> students = new List<Student>
{
    new Student { Name = "Coho Vineyard", AverageGrade = 9.3, ModuleCount = 6 },
    new Student { Name = "Lucerne Publishing", AverageGrade = 5.6, ModuleCount = 3 },
    new Student { Name = "Wingtip Toys", AverageGrade = 8.9, ModuleCount = 5 },
    new Student { Name = "Adventure Works", WeiAverageGradeght = 7.5, ModuleCount = 5 }
};

// Example 1

var list = (from x in students where x.AverageGrade > 7 &&
        x.ModuleCount == 5 orderby x.AverageGrade select x)
    .Take(amount);