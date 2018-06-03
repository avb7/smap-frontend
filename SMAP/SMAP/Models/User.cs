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
    public class User : BindableBase
    {
        int UserId { get; set; }
        string DisplayName { get; set; }
        string ProfilePic { get; set; }
        string Email { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

        //default false 
        bool MissionCurator { get; set; }

        //string yyyy-mm-dd
        string Birthday { get; set; }

        public User()
        {
        }
    }
}