using TestAPI.Models;

namespace TestAPI.Dto
{
    public class CardPostDto
    {
        public string IdPost { get; set; }
        public string Title { get; set; }
        public string Directory { get; set; }
        public string Type { get; set; }
        public DateTime DatePost { get; set; }
        public TimeSpan TimePost { get; set; }
        public string TagsPost { get; set; }
        public string AreaLost { get; set; }
        public string StatusPost { get; set; }
    }
}
