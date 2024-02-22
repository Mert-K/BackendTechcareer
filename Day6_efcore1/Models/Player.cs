namespace Day6_efcore1.Models;

public class Player
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int BranchId { get; set; }
    public Branch Branch { get; set; } //navigation property
    public string TeamId { get; set; }
    public Team Team { get; set; }
    public int OutfitId { get; set; } //forma
    public Outfit Outfit { get; set; }
    public decimal Price { get; set; }
}
