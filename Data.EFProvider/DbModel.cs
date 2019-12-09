using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EFProvider
{
    public class DbModel : DbContext
    {
        // Info: Following this guide https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/migrations/
        // > Enable-Migrations

        public DbSet<CalendarEvent> CalendarEvents { get; set; }
    }
}
