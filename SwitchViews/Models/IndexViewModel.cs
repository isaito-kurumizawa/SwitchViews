using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SwitchViews.Models
{
    public class IndexViewModel
    {
        public IndexViewModel()
        {
            this.Index = nameof(this.Index);
        }
        public string Index { get; set; }
    }
}