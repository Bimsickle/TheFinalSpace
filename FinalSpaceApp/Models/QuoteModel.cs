namespace FinalSpaceApp.Models;

public class QuoteModel
{
    public int Id { get; set; } = 0;
    public int? CharacterId { get; set; } = 0;
    public string Quote { get; set; } = string.Empty;
    public string By { get; set; } = string.Empty;
    public string Character { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;

    public void ExtractCharacterId()
    {
        if (string.IsNullOrEmpty(Character))
        {
            CharacterId = null;
            return;
        }

        // Extract the last segment of the URL
        var segments = Character.Split('/');
        var lastSegment = segments.LastOrDefault();

        // Parse the last segment to an integer and set CharacterId
        if (int.TryParse(lastSegment, out int characterId))
        {
            CharacterId = characterId;
        }
        else
        {
            CharacterId = null;
        }
    }
}
