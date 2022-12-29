namespace WebApi.Models.Dto
{
    public class VowelDTO
    {
        public List<char> Vowels { get; set; } = new List<char>();
        public List<int>? VowelsCount { get; set; } = new List<int>();
        public string YourText { get; set; }
        public string Lang { get; set; } = "Türkçe";

    }
}
