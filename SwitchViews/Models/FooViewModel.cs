using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SwitchViews.Models
{
    public class FooViewModel
    {
        public FooViewModel()
        {
            this.Foo = nameof(this.Foo);
        }
        public string Foo { get; set; }
    }
}