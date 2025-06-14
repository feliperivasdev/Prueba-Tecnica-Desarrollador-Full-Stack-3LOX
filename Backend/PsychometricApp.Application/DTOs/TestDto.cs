namespace PsychometricApp.Application.DTOs;

public class TestDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public int CreatorId { get; set; }
    public DateTime CreatedAt { get; set; }
}