using FlexibleAutomationTool.DL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.DL.Context
{
    public class FlexibleAutomationToolContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Rule> Rules { get; set; }
        public DbSet<Script> Scripts { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        public FlexibleAutomationToolContext()
        {

        }
    }
}
