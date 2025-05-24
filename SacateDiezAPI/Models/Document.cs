

namespace SacateDiezAPI.Models.Entities;

public class Document
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string courseName { get; set; } = null!;
    public string fileUrl { get; set; } = null!;
}