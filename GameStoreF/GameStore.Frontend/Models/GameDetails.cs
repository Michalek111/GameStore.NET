using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using GameStore.Frontend.Converters;

namespace GameStore.Frontend.Models;

public class GameDetails
{
    
    public int ID { get; set; }

    [Required]
    [StringLength(50)]

    public required string Name { get; set; }

    [Required(ErrorMessage = "The Genre field is required. Choose one of genre.")]

    [JsonConverter(typeof(StringConverter))]
    public string? GenreID { get; set; }

    [Range(1,500)]
    public decimal Price { get; set; }
    public DateOnly ReleaseDate { get; set; }
}
