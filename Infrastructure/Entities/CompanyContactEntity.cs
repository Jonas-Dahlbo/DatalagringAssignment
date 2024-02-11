namespace Infrastructure.Entities;

public class CompanyContactEntity
{
    public string CustomerId { get; set; } = null!;
    public CustomerEntity Customer { get; set; } = null!;
    public string CompanyId { get; set; } = null!;
    public CompanyEntity Company { get; set; } = null!;
}
