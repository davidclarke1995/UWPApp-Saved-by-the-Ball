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
using Windows.Media.Playback;
using Windows.Media.Core;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //MediaPlayer player;
        public MainPage()
        {
            this.InitializeComponent();
            //player = new MediaPlayer;


            ElementSoundPlayer.State = ElementSoundPlayerState.On;

            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(320, 320));
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBoundsChanged += MainPage_VisibleBoundsChanged;

            int Rating = 5;
            DataContext = Rating;





            var Point = new Geopoint(new BasicGeoposition()
            {
                Latitude = 53.463058900,
                Longitude = -2.291340100
            });

            //Map.Center = Point;
            //The variable names for the picture and flag
            //MapControl.SetLocation(Pic, Point);
            //MapControl.SetLocation(Flag, Point);
        }

        //Sizing of the menu bar
        private void MainPage_VisibleBoundsChanged(Windows.UI.ViewManagement.ApplicationView sender, object args)
        {   //Desktop view open
            var width = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Width;
            if (width >= 720)
            {
                SView.DisplayMode = SplitViewDisplayMode.CompactInline;
                SView.IsPaneOpen = true;
            }
            //Tablet view minimised bar with icons visible
            else if (width >= 360)
            {
                SView.DisplayMode = SplitViewDisplayMode.CompactOverlay;
                SView.IsPaneOpen = false;
            }
            //Phone view, no bar just the hamburger menu
            else
            {
                SView.DisplayMode = SplitViewDisplayMode.Overlay;
                SView.IsPaneOpen = false;
            }
        }

        private void TextBlock_PointerPressed(object sender, PointerRoutedEventArgs e)
        {

        }

        private void Rectangle_PointerPressed(object sender, PointerRoutedEventArgs e)
        {

        }

        private void HomePage(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Home));
            // MyText.Text = "Hello World";
        }

        private void ManUnitedPage(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.ManUited));
            // MyText.Text = "Hello World";
        }

        private void ChelseaPage(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Chelsea));
            // MyText.Text = "Hello World";
        }

        private void LiverpoolPage(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Liverpool));
            // MyText.Text = "Hello World";
        }

        private void About(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(About));
            // MyText.Text = "Hello World";
        }

        private void Video(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.PremierLeague));
            // MyText.Text = "Hello World";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SView.IsPaneOpen = !SView.IsPaneOpen;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
