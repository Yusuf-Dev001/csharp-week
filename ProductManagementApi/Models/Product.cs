using System.ComponentModel.DataAnnotations;

namespace ProductManagementApi.Models;

public class Product
{
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    [Range(0.01, 999999999)]
    public decimal Price { get; set; }
}