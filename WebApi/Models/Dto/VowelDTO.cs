namespace WebApi.Models.Dto
{
    public class VowelDTO
    {
        public List<char> Txttr { get; set; }
        public List<char> Txten { get; set; }
        public List<char>? Vowels { get; set; }
        public string YourText { get; set; }

        public int VowelCount { get { return Vowels.Count(); } }
        public string Lang { get; set; } = "Türkçe";

    }
}
