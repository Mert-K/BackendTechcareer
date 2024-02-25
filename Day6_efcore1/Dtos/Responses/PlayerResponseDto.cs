using Day6_efcore1.Models;

namespace Day6_efcore1.Dtos.Responses;

public class PlayerResponseDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public TeamDto Team { get; set; } //TeamDto, "System.Text.Json.JsonException: A possible object cycle was detected" hatasını kırmak için yazıldı.
    public OutfitDto Outfit { get; set; } //OutfitDto, "System.Text.Json.JsonException: A possible object cycle was detected" hatasını kırmak için yazıldı.
    public BranchDto Branch { get; set; } //BranchDto, "System.Text.Json.JsonException: A possible object cycle was detected" hatasını kırmak için yazıldı.
    public decimal Price { get; set; }
}
