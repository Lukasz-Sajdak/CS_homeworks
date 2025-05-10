using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_commands
{
    public class TripScheduler
    {
        private readonly List<IVisitTouristAttraction> schedule = new List<IVisitTouristAttraction>();

        public void AddVisit(IVisitTouristAttraction visit)
        {
            schedule.Add(visit);
        }

        public void Trip()
        {
            Console.WriteLine(">> Start wycieczki:");
            foreach (var visit in schedule)
            {
                visit.Visit();
            }
            Console.WriteLine(">> Koniec wycieczki.\n");
        }

        public void ClearSchedule()
        {
            schedule.Clear();
        }
    }
}
