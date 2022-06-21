using treninkovyDenik.Model;

namespace treninkovyDenik.Logika.Cvik
{
    public class DatabázeCvikService : ICvikService
    {
        public IEnumerable<Cvik> GetActivities()
        {
            return new[] { new Cvik() { Name = "Nevíme" } };
        }
    }
}
