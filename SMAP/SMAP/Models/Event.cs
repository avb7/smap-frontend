using Newtonsoft.Json;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SMAP.Models
{
    public class Event
    {
        int Id { get; set; }
        string name { get; set; }
        string image { get; set; }
        string type { get; set; }

        string host { get; set; }
        string description { get; set; }
        Location location { get; set; }

        //yyyy-mm-dd
        string event_date { get; set; }
        //hh:mm:ss
        string start_date { get; set; }
        //hh:mm:ss
        string end_time { get; set; }

        bool is_public { get; set; }
        bool is_free { get; set; }
        int points { get; set; }


        public Event()
        {
        }
    }
}
