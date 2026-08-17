public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
<<<<<<< HEAD
    public double Grade { get; set; }

    public Student(string name, int age, double grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Grade: {Grade}");
=======

    public void Study()
    {
        Console.WriteLine($"{Name} is studying.");
>>>>>>> feature/git-practice
    }
}