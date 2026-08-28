using System.ComponentModel.DataAnnotations;

namespace EnterprisePlatform.API.Models;

public class ServiceRequest
{
    public Guid Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; }

    public Guid CitizenId { get; set; }

    public Citizen Citizen { get; set; } = null!;

    public RequestStatus Status { get; set; } = RequestStatus.Pending;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}

public enum RequestStatus
{
    Pending,
    InProgress,
    Completed,
    Rejected
}
