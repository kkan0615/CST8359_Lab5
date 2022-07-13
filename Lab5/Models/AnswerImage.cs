using System.ComponentModel.DataAnnotations;

namespace Lab5.Models
{
    public enum Question
    {
        Earth, Computer
    }

    public class AnswerImage
    {
        public int AnswerImageId { get; set; }
        [Required]
        [Display(Name = "File Name")]
        public string FileName { get; set; }
        [Required]
        [Url]
        public string Url { get; set; }
        [Display(Name = "Question")]
        public Question Question { get; set; }

    }
}
