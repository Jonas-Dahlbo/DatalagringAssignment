using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class RoleEntity
{
    [Key]
    public string Id = Guid.NewGuid().ToString();
    [Required, StringLength(50)]
    public string RoleName { get; set; } = null!;
}
