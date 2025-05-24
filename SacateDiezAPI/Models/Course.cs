namespace SacateDiezAPI.Models.Entities;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string code { get; set; } = null!;
    public int docCount { get; set; }
    public bool isCompleted { get; set; }

}