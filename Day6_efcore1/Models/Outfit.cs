namespace Day6_efcore1.Models
{
    public class Outfit
    {
        public int Id { get; set; }
        public OutfitType Type { get; set; }
        public short No { get; set; }
        public string BrandName { get; set; }

        //public int PlayerId { get; set; } 1'e 1 ilişide Player tablosunda OutfitId belirtildiği                                   için Outfit tablosunda PlayerId belirtilmiyor.
        public Player Player { get; set; } //1'e 1 ilişkide navigation property. Foreign Key                                         property'si (=OutfitId) Player tablosunda yazıldı.
    }

    public enum OutfitType
    {
        Winter,
        Summery
    }
}
