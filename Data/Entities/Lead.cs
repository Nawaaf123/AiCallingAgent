namespace AiCallingAgent.Data.Entities;

public class Lead
{
    public Guid Id { get; set; }
    public Guid CallRecordId { get; set; }
    public string? Name { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? ProductInterest { get; set; }
    public string? Notes { get; set; }
    public DateTime CreatedAtUtc { get; set; }
}