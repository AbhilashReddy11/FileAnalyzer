// File: InputOutputModel.cs
using System.ComponentModel.DataAnnotations;

namespace FileAnalyzer.Models
{
    public class InputOutputModel
    {
        [Required]
        public string Prompt { get; set; }
        public string Response { get; set; }
        public string ResponseFileUrl { get; set; }
    }
}
