namespace intro.Entities;

public class Course
{
    private string _Name;
    public int Id { get; set; }
    public string Name { get { return _Name ?? "Fu"; } set { _Name = value; } } 
    public string Description { get; set; }
    public double Price { get; set; }
}
