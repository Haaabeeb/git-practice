public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Study()
    {
        Console.WriteLine($"{Name} is studying.");
    }
}