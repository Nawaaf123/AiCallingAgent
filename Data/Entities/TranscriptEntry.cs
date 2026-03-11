namespace AiCallingAgent.Data.Entities;

public class TranscriptEntry
{
    public Guid Id { get; set; }
    public Guid CallRecordId { get; set; }
    public string Speaker { get; set; } = default!;
    public string Text { get; set; } = default!;
    public DateTime CreatedAtUtc { get; set; }
}