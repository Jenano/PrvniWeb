namespace treninkovyDenik.Model;

namespace treninkovyDenik.Logika.Trenink
{
    public class VPametiTreninkService : ITreninkService
    {
        public VPametiTreninkService()
        {

        }

        public IEnumerable<Trenink> GetActivities()
        {
            return new[] { new Trenink() { Cas = DateTime.Now } };
        }
    }
}
