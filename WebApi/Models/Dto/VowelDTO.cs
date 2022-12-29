namespace WebApi.Models.Dto
{
    public class VowelDTO
    {
        public List<char> Vowels { get; set; }
        public List<int>? VowelsCount { get; set; }
        public string YourText { get; set; }
        public string Lang { get; set; } = "Türkçe";

    }
}
