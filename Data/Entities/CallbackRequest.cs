namespace AiCallingAgent.Data.Entities;

public class CallbackRequest
{
    public Guid Id { get; set; }
    public Guid CallRecordId { get; set; }
    public string? Name { get; set; }
    public string Phone { get; set; } = default!;
    public string? PreferredTime { get; set; }
    public string Reason { get; set; } = default!;
    public DateTime CreatedAtUtc { get; set; }
}