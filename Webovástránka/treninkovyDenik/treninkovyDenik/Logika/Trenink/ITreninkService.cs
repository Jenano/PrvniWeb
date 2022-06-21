using treninkovyDenik.Model;

namespace treninkovyDenik.Logika.Trenink
{
    
        public interface ITreninkService
        {
            IEnumerable<Trenink> GetActivities();
        }
    
}
