namespace FinalSpaceApp.Models
{
    public class CharacterModel
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Species { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string Hair { get; set; } = string.Empty;
        public string Origin { get; set; } = string.Empty;
        public List<string>  Alias { get; set; } = new List<string>();
        public List<string> Abilities { get; set; } = new List<string>();
        public string Img_Url { get; set; } = string.Empty;

        public List<QuoteModel>? Quotes { get; set; } = new List<QuoteModel>();
    }
}
