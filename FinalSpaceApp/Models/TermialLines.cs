using Microsoft.AspNetCore.Components;

namespace FinalSpaceApp.Models
{
    public class TermialLines
    {
        public int Id { get; set; } = 0;
        public string Class { get; set; } = "system";
        public string Value { get; set; } = string.Empty;
        public string Type { get; set; } = "text"; // "text", "image", "input", "button"
        public string ImageUrl { get; set; } = string.Empty; // For image content

        // Options
        public List<string> Options { get; set; } = new(); // For input options
        public string SelectedOption { get; set; } = string.Empty;

        //public Action<ChangeEventArgs>? OnChangeFunction { get; set; }
        public Func<ChangeEventArgs, Task> OnChangeFunction { get; set; } = e => Task.CompletedTask;
        
        //Button
        public string ButtonText { get; set; } = string.Empty; // For button text
        public Func<Task> OnClickFunction { get; set; } = () => Task.CompletedTask;
    }
}
