class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public Student(string name, string surname)
    {
        this.Name = name;
        this.Surname = surname;
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }

        Student student = obj as Student;

        return (Name + Surname).Equals(student.Name + student.Surname);
    }

    public override int GetHashCode()
    {
        return (Name + Surname).GetHashCode();
    }
}