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
    public class User 
    {

        public int UserId { get; set; }
        public string display_name { get; set; }
        public string profile_pic { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }

        //default false 
        public bool mission_curator { get; set; }

        //string yyyy-mm-dd
        public string birthday { get; set; }
         
        public IDictionary<int, Location> location { get; set; }
        public User()
        {
        }
    }
}