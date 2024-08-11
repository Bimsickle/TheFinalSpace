namespace FinalSpaceApp.Models
{
    public class LocationModel
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public List<string> Inhabitants { get; set; } = new List<string>();
        public List<string> Notable_Residents { get; set; } = new List<string>();
        public string Img_Url { get; set; } = string.Empty;
    }
}
