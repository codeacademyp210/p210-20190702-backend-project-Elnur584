using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LorventWeekendTask.Areas.Admin.Models
{
    public class NewsAdd
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string DateTime { get; set; }

        public string Category { get; set; }
    }
}