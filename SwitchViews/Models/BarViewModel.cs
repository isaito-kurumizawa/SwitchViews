using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SwitchViews.Models
{
    public class BarViewModel
    {
        public BarViewModel()
        {
            this.Bar = nameof(this.Bar);
        }
        public string Bar { get; set; }
    }
}