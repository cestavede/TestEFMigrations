using Data.EFProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DbModel())
            {
                var newId = Guid.NewGuid();
                var shortId = newId.ToString().Substring(0, 5).ToUpper();
                db.CalendarEvents.Add(new CalendarEvent {   CalendarEventId = newId,
                                                            Name = $"Hello there {shortId}", 
                                                            Start= DateTime.UtcNow,
                                                            Location = $"Conference center {shortId}"});
                db.SaveChanges();

                foreach (var evnt in db.CalendarEvents)
                {
                    Console.WriteLine(evnt.Name);
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
