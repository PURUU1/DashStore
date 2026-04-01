using DashStore.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

public class Product
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string ImageUrl { get; set; }

    public int CategoryId { get; set; }
    [ForeignKey("CategoryId")]
    public Category Category { get; set; }

    // ONLY THIS ONE goes to the Database
    public string SpecificationsJson { get; set; }

    [NotMapped] // THIS PREVENTS THE DUPLICATE COLUMN ERROR
    public Dictionary<string, List<string>> Specifications
    {
        get => string.IsNullOrEmpty(SpecificationsJson) ? new() : JsonSerializer.Deserialize<Dictionary<string, List<string>>>(SpecificationsJson);
        set => SpecificationsJson = JsonSerializer.Serialize(value);
    }
}