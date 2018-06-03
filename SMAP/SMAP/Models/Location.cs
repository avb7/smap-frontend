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
    public class Location
    {
        int Id { get; set; }
        string Street { get; set; }
        string City { get; set; }
        string State { get; set; }
        int Zip { get; set; }
        string Country { get; set; }
        float Latitude { get; set; }
        float Longitude { get; set; }


        public Location()
        {
        }
    }
}
