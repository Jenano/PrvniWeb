using treninkovyDenik.Model;

namespace treninkovyDenik.Logika.Trenink
{

    public interface ITrenink
    {
        IEnumerable< Trenink > GetActivities();
    }

}
