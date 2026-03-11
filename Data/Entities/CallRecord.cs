namespace AiCallingAgent.Data.Entities;

public class CallRecord
{
    public Guid Id { get; set; }
    public string TwilioCallSid { get; set; } = default!;
    public string? CallerNumber { get; set; }
    public DateTime StartedAtUtc { get; set; }
    public DateTime? EndedAtUtc { get; set; }
    public string Status { get; set; } = "InProgress";
    public string? Summary { get; set; }
    public string? Disposition { get; set; }
    public bool TransferRequested { get; set; }
}