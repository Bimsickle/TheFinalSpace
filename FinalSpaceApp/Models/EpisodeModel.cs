namespace FinalSpaceApp.Models;

public class EpisodeModel
{
    public int Id { get; set; } = 0;
    public string Name { get; set; } = string.Empty;
    public string Air_Date { get; set; } = string.Empty;
    public string Director { get; set; } = string.Empty;
    public string Writer { get; set; } = string.Empty;
    public List<string> Characters { get; set; } = new List<string>();
    public string Img_Url { get; set; } = string.Empty;
    public List<int>? CharacterIds { get; set; }

    public void ExtractCharacterIds()
    {
        if (Characters.Count <1)
        {
            CharacterIds = null;
            return;
        }
        var ids = new List<int>();
        foreach (var character in Characters)
        {
            var segments = character.Split('/');
            var lastSegment = segments.LastOrDefault();

            if (int.TryParse(lastSegment, out int characterId))
            {
                ids.Add(characterId);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        CharacterIds = ids;
    }
}
