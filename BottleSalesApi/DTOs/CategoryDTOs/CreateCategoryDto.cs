namespace BottleSalesApi.DTOs.CategoryDTOs;

public class CreateCategoryDto
{
    public CreateCategoryDto(string name, string? description)
    {
        Name = name;
        Description = description;
    }

    public string Name { get; set; }
    public string? Description { get; set; }
}