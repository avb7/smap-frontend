using System;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
using Xamarin.Forms.GoogleMaps;

using Xamarin.Forms;

namespace SMAP.Views
{
    public partial class DashboardPage : ContentPage
    {

        public DashboardPage()
        {
            InitializeComponent();

            map.MapStyle = MapStyle.FromJson(getMapStyleJson());
        }

        public string getMapStyleJson(){
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(DashboardPage)).Assembly;
            System.IO.Stream stream = assembly.GetManifestResourceStream("SMAP.Helpers.GoogleMapsStyle.json");
            string text = "";
            using (var reader = new System.IO.StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }

            return text;
        }
    }
}
