namespace BottleSalesApi.DTOs.CategoryDTOs;

public class UpdateCategoryDto
{
    public UpdateCategoryDto(string name, string? description)
    {
        Name = name;
        Description = description;
    }

    public string Name { get; set; }
    public string? Description { get; set; }
}