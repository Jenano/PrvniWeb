using treninkovyDenik.Model;

namespace treninkovyDenik.Logika.Trenink
{
    public class Trenink : ITrenink
    {

        public ITreninkService treninkService;
        public Trenink(ITreninkService treninkService)
        {
            this.treninkService = treninkService;
        }

        public IEnumerable<Trenink> GetActivities()
        {
            return treninkService.GetActivities();
        }
    }
}
