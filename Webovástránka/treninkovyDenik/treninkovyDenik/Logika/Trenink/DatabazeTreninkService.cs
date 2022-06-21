using treninkovyDenik.Model;

namespace treninkovyDenik.Logika.Trenink
{
    public class DatabázeTreninkService : ITreninkService
    {
        public IEnumerable<Trenink> GetActivities()
        {
            return new[] { new Trenink() { Cas = DateTime.Now } };
        } };
        }
    }
}
