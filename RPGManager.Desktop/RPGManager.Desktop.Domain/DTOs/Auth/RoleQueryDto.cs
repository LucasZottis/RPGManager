namespace RPGManager.Desktop.Domain.DTOs.Auth;

public class RoleQueryDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
}