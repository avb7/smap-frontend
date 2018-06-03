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
        string Name { get; set; }
        string ImageUrl { get; set; }
        string Type { get; set; }

        string HostEmail { get; set; }
        string Description { get; set; }
        Location Location { get; set; }

        //yyyy-mm-dd
        string Date { get; set; }
        //hh:mm:ss
        string StartTime { get; set; }
        //hh:mm:ss
        string EndTime { get; set; }

        bool IsPublic { get; set; }
        bool IsFree { get; set; }
        int Points { get; set; }


        public Event()
        {
        }
    }
}
