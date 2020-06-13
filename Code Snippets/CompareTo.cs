// Used for sorting

public int CompareTo(Student other)
{
    if (other != null)
    {
        if (this.Surname.CompareTo(other.Surname) == 0)
        {
            return this.Name.CompareTo(other.Name);
        }
        else
        {
            return this.Surname.CompareTo(other.Surname);
        }
    }
}