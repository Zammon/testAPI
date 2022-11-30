using TestAPI.Models;

namespace TestAPI.Dto
{
    public class FilterItemDto
    {

        public int IdFilter { get; set; }

        public string NameFilter { get; set; }

        public List<string> NameItemFilter { get; set; }
    }
}
