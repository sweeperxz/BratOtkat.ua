using System.ComponentModel.DataAnnotations;

namespace BratOtkat.Domain.Models;

public class Position
{
    public Guid Id { get; set; }

    [Required] [MaxLength(100)] public string Name { get; set; } = nameof(Position);

    [MaxLength(500)] public string Description { get; set; } = string.Empty;

    [Range(0, double.MaxValue)] public decimal Kickbacks { get; set; }

    [Range(0, double.MaxValue)] public decimal Price { get; set; }

    [Range(0, 10)] public int DangerLevel { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }

    public bool IsActive { get; set; } = true;


    [MaxLength(50)] public string RegionCode { get; set; } = string.Empty;

    [Range(0, 100)] public int InfluenceLevel { get; set; } = 0;
}