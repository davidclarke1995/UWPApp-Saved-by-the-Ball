using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MyApp.Pages.Maps
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OldTrafford : Page
    {
        public OldTrafford()
        {
            this.InitializeComponent();

            var Point = new Geopoint(new BasicGeoposition()
            {
                Latitude = 53.463058900,
                Longitude = -2.291340100
            });

            Map.Center = Point;
            //The variable names for the picture and flag
            MapControl.SetLocation(Pic, Point);
            MapControl.SetLocation(Flag, Point);
        }
    }
}
