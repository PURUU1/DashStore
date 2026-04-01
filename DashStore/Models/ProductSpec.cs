using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace DashStore.Models
{
    public class ProductSpec
    {
        [Key]
        public int SpecId { get; set; }

        // --- Foreign Key ---
        [Required]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        [ValidateNever]
        public Product Product { get; set; }

        // --- Specification Name ---
        [Required]
        [MaxLength(100)]
        public string SpecName { get; set; } // e.g., "Color", "RAM", "Included Accessories"

        // --- 1. The Database Column (Hidden from your Views) ---
        // SQL Server will store this as: '["Black", "Blue", "Silver"]'
        [Required]
        public string SpecValuesJson { get; set; }

        // --- 2. The C# Array/List (What you actually use) ---
        // [NotMapped] tells Entity Framework NOT to make a SQL column for this
        [NotMapped]
        public List<string> SpecValues
        {
            get
            {
                // Convert the SQL string back into a C# List when reading
                if (string.IsNullOrEmpty(SpecValuesJson))
                {
                    return new List<string>();
                }
                return JsonSerializer.Deserialize<List<string>>(SpecValuesJson);
            }
            set
            {
                // Convert the C# List into a JSON string when saving
                SpecValuesJson = JsonSerializer.Serialize(value);
            }
        }
    }
}