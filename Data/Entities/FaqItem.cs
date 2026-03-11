namespace AiCallingAgent.Data.Entities;

public class FaqItem
{
    public Guid Id { get; set; }

    public string Question { get; set; } = string.Empty;

    public string Answer { get; set; } = string.Empty;

    public string? Category { get; set; }

    public bool IsActive { get; set; } = true;
}