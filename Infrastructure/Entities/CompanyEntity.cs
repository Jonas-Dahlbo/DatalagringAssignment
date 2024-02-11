using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class CompanyEntity
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    [Required, StringLength(100)]
    public string CompanyName { get; set; } = null!;
    [Required, StringLength(50)]
    public string OrgNr { get; set; } = null!;
}
