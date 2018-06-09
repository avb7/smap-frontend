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
        public int event_id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string type { get; set; }

        public string host { get; set; }
        public string description { get; set; }
        public Dictionary<dynamic, dynamic> location { get; set; }

        //yyyy-mm-dd
        public string event_date { get; set; }
        //hh:mm:ss
        public string start_time { get; set; }
        //hh:mm:ss
        public string end_time { get; set; }

        public bool is_public { get; set; }
        public bool is_free { get; set; }
        public int points { get; set; }


        public Event()
        {
        }
    }
}
