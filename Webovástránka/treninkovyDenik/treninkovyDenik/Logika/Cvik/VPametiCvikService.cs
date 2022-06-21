using treninkovyDenik.Model;

namespace treninkovyDenik.Logika.Cvik
{
    public class VPametiCvikService : ICvikService
    {
        public VPametiCvikService()
        {

        }

        public IEnumerable<Cvik> GetActivities()
        {
            return new[] { new Cvik() { Name = "Neznámé" } };
        }
    }
}
