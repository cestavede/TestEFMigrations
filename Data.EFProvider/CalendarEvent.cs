using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EFProvider
{
    public class CalendarEvent
    {
        public Guid CalendarEventId { get; set; }
        public DateTime Start { get; set; }
        public string Name { get; set; }

        public string Location { get; set; }
    }
}
