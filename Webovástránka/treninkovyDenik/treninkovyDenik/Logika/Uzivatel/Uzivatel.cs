using treninkovyDenik.Model;

namespace treninkovyDenik.Logic.Uzivatel1
{
    public class Uzivatel:IUzivatel
    {

        public IUzivatelService uzivatelService;
        public Uzivatel(IUzivatelService uzivatelService)
        {
            this.uzivatelService = uzivatelService;
        }

        public IEnumerable<Uzivatel> GetActivities()
        {
            return uzivatelService.GetActivities();
        }
    }
}

