using Ivanov_ASP.NET_04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Ivanov_ASP.NET_04.ViewModels
{
    public class ActorsViewModel
    {
        public IEnumerable<Country> Countries { get; set; }

        public IEnumerable<Actor> Actors { get; set; }
    }
}
