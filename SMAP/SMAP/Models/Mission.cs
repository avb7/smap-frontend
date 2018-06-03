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
    public class Mission
    {
        int Id { get; set; }
        string Name { get; set; }
        string ImageUrl { get; set; }
        string Description { get; set; }
        Location Location { get; set; }


        string Date { get; set; }
        string StartTime { get; set; }
        string EndTime { get; set; }
        int Points { get; set; }


        public Mission()
        {
        }
    }
}
