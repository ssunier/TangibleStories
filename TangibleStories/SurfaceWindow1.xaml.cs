using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Surface;
using Microsoft.Surface.Presentation;
using Microsoft.Surface.Presentation.Controls;
using Microsoft.Surface.Presentation.Input;
using System.IO;

namespace TangibleStories
{
    /// <summary>
    /// Interaction logic for SurfaceWindow1.xaml
    /// </summary>
    public partial class SurfaceWindow1 : SurfaceWindow
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public SurfaceWindow1()
        {
            InitializeComponent();

            // Add handlers for window availability events
            AddWindowAvailabilityHandlers();

        }
        private void USButton_Click(object sender, RoutedEventArgs e)
        {
            scatter.ItemsSource =
                Directory.GetFiles(@"../../Resources/img/US/", "*.jpg");
            ClearButton.Visibility = Visibility.Visible;
            TripInfo.Content = "The United States of America (September 1992-?)" +
                Environment.NewLine + "I was born in New York in 1992 and have spent the majority of my life living" +
                "in 4 states and exploring 26 more!";
            if (showInfo.IsChecked == true)
            {
                TripInfo.Visibility = Visibility.Visible;
            }
        }
        private void CanadaButton_Click(object sender, RoutedEventArgs e)
        {
            scatter.ItemsSource =
                Directory.GetFiles(@"../../Resources/img/Canada/", "*.jpg");
            ClearButton.Visibility = Visibility.Visible;
            TripInfo.Content = "Canada (February 2011)" +
                Environment.NewLine + "My family and I went to Canada to go Cat Skiing in British Columbia." +
                "This was some of the most incredible skiing I have ever been lucky enough to enjoy";
            if (showInfo.IsChecked == true)
            {
                TripInfo.Visibility = Visibility.Visible;
            }
        }
        public void TCButton_Click(object sender, RoutedEventArgs e)
        {
            scatter.ItemsSource =
                Directory.GetFiles(@"../../Resources/img/TC/", "*.jpg");
            ClearButton.Visibility = Visibility.Visible;
            TripInfo.Content = "Turks & Caicos (March 2014)" +
                Environment.NewLine + "My mother and I went to Turks and Caicos for my Spring Break." +
                "I got scuba certified and completed my Wellesley PE Requirement.";
            if (showInfo.IsChecked == true)
            {
                TripInfo.Visibility = Visibility.Visible;
            }
        }
        public void EcuadorButton_Click(object sender, RoutedEventArgs e)
        {
            scatter.ItemsSource =
                Directory.GetFiles(@"../../Resources/img/Ecuador/", "*.jpg");
            ClearButton.Visibility = Visibility.Visible;
            TripInfo.Content = "Ecuador (August 2011)" +
                Environment.NewLine + "My family and I traveled to Ecuador's Galapagos Islands for a cruise and an incredible wildlife safari.";
            if (showInfo.IsChecked == true)
            {
                TripInfo.Visibility = Visibility.Visible;
            }
        }
        public void PeruButton_Click(object sender, RoutedEventArgs e)
        {
            scatter.ItemsSource =
                Directory.GetFiles(@"../../Resources/img/Peru/", "*.jpg");
            ClearButton.Visibility = Visibility.Visible;
            TripInfo.Content = "Peru (August 2011)" +
                Environment.NewLine + "My family and I traveled to Peru.  We explored anciant Incan ruins and the Spanish Colonial cities, " +
                "doing lots of hiking along the way!";
            if (showInfo.IsChecked == true)
            {
                TripInfo.Visibility = Visibility.Visible;
            }
        }
        private void SwitzerlandButton_Click(object sender, RoutedEventArgs e)
        {
            scatter.ItemsSource =
                Directory.GetFiles(@"../../Resources/img/Switzerland/", "*.jpg");
            ClearButton.Visibility = Visibility.Visible;
            TripInfo.Content = "Switzerland (1994, 1998, 2006, August 2013)" +
                Environment.NewLine + "My family is Swiss, and so I have been lucky enough to visit this beautiful mountain country several times in my life. " +
                "These are photos from my most recent trip in the summer of '13.";
            if (showInfo.IsChecked == true)
            {
                TripInfo.Visibility = Visibility.Visible;
            }
        }
        private void AustriaButton_Click(object sender, RoutedEventArgs e)
        {
            scatter.ItemsSource =
                Directory.GetFiles(@"../../Resources/img/Austria/", "*.jpg");
            ClearButton.Visibility = Visibility.Visible;
            TripInfo.Content = "Austria (July 2004)" +
                Environment.NewLine + "My family and I stayed in Innsbruck for 2 days while en route from Munich to Italy.  The schnitzel was devine.";
            if (showInfo.IsChecked == true)
            {
                TripInfo.Visibility = Visibility.Visible;
            }
        }
        private void FranceButton_Click(object sender, RoutedEventArgs e)
        {
            scatter.ItemsSource =
                Directory.GetFiles(@"../../Resources/img/France/", "*.jpg");
            ClearButton.Visibility = Visibility.Visible;
            TripInfo.Content = "France (July 2011, August 2013)" +
                Environment.NewLine + "One of my best friends lives in Normandy and I have been lucky enough to visit her country and explore both the north and the south with her.";
            if (showInfo.IsChecked == true)
            {
                TripInfo.Visibility = Visibility.Visible;
            }
        }
        private void GermanyButton_Click(object sender, RoutedEventArgs e)
        {
            scatter.ItemsSource =
                Directory.GetFiles(@"../../Resources/img/Germany/", "*.jpg");
            ClearButton.Visibility = Visibility.Visible;
            TripInfo.Content = "Germany (July 2004)" +
                Environment.NewLine + "My family and I spent two days in Munich exploring the city my mother lived in for 3 years during the beginning of her career at the Pentagon.";
            if (showInfo.IsChecked == true)
            {
                TripInfo.Visibility = Visibility.Visible;
            }
        }
        private void ItalyButton_Click(object sender, RoutedEventArgs e)
        {
            scatter.ItemsSource =
                Directory.GetFiles(@"../../Resources/img/Italy/", "*.jpg");
            ClearButton.Visibility = Visibility.Visible;
            TripInfo.Content = "Italy (July 2004)" +
                Environment.NewLine + "My family and I traveled to Europe in 2004 to attend my Zio Urbano's 80th birthday party.";
            if (showInfo.IsChecked == true)
            {
                TripInfo.Visibility = Visibility.Visible;
            }
        }
        private void UKButton_Click(object sender, RoutedEventArgs e)
        {
            scatter.ItemsSource =
                Directory.GetFiles(@"../../Resources/img/UK/", "*.jpg");
            ClearButton.Visibility = Visibility.Visible;
            TripInfo.Content = "United Kingdon (August 2014)" +
                Environment.NewLine + "I traveled to the UK to begin my EuroTrip in the summer of 2014.  I loved walking around London and Edinbourogh with my camera.";
            if (showInfo.IsChecked == true)
            {
                TripInfo.Visibility = Visibility.Visible;
            }
        }
        private void NorwayButton_Click(object sender, RoutedEventArgs e)
        {
            scatter.ItemsSource =
                Directory.GetFiles(@"../../Resources/img/Norway/", "*.jpg");
            ClearButton.Visibility = Visibility.Visible;
            TripInfo.Content = "Norway (July 2009)" +
                Environment.NewLine + "My parents and I traveled to Norway in 2009 to explore the land of the Fjiords and Trolls!";
            if (showInfo.IsChecked == true)
            {
                TripInfo.Visibility = Visibility.Visible;
            }
        }

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            scatter.ItemsSource = null;
            ClearButton.Visibility = Visibility.Hidden;
            TripInfo.Content = "";
            TripInfo.Visibility = Visibility.Hidden;
        }

        private void TripInfo_Checked(object sender, RoutedEventArgs e)
        {
            if (showInfo.IsChecked == true && TripInfo != null)
            {
                TripInfo.Visibility = Visibility.Visible;
            }
            if (hideInfo.IsChecked == true)
            {
                TripInfo.Visibility = Visibility.Hidden;
            }

        }

        /// <summary>
        /// Occurs when the window is about to close. 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            // Remove handlers for window availability events
            RemoveWindowAvailabilityHandlers();
        }

        /// <summary>
        /// Adds handlers for window availability events.
        /// </summary>
        private void AddWindowAvailabilityHandlers()
        {
            // Subscribe to surface window availability events
            ApplicationServices.WindowInteractive += OnWindowInteractive;
            ApplicationServices.WindowNoninteractive += OnWindowNoninteractive;
            ApplicationServices.WindowUnavailable += OnWindowUnavailable;
        }

        /// <summary>
        /// Removes handlers for window availability events.
        /// </summary>
        private void RemoveWindowAvailabilityHandlers()
        {
            // Unsubscribe from surface window availability events
            ApplicationServices.WindowInteractive -= OnWindowInteractive;
            ApplicationServices.WindowNoninteractive -= OnWindowNoninteractive;
            ApplicationServices.WindowUnavailable -= OnWindowUnavailable;
        }

        /// <summary>
        /// This is called when the user can interact with the application's window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnWindowInteractive(object sender, EventArgs e)
        {
            
        }

        private void OnWindowNoninteractive(object sender, EventArgs e)
        {
           
        }
         
        private void OnWindowUnavailable(object sender, EventArgs e)
        {
           
        }
        private void OnItemClicked(object sender, RoutedEventArgs e)
        {

        }

        private void SurfaceWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void TagVisualizer_VisualizationAdded(object sender, TagVisualizerEventArgs e)
        {
            string s = e.TagVisualization.VisualizedTag.Value.ToString();

            if (s.Equals("1"))
            {
                Description.Visibility = Visibility.Visible;
                Description.Content = "Some Travel Stats:" +
                    Environment.NewLine + Environment.NewLine + "Visited Countries: 12" +
                    Environment.NewLine + "Visited States: 27" +
                    Environment.NewLine + "Places Lived: NY, CA, IL, MA" +
                    Environment.NewLine + "First Trip: Switzerland, 18 mo" +
                    Environment.NewLine + "Latest Trip: GHC in Phoenix, AZ";
            }
            if (s.Equals("2"))
            {
                string videosPath = @"C:\Users\Orit\Documents\GitHub\TangibleStories\TangibleStories\TangibleStories\Resources";

                string targetVideo = videosPath + @"\TangibleStories_Demo.MP4";

                ScatterViewItem item = new ScatterViewItem();
                scatter.Items.Add(item);

                MediaElement video = new MediaElement();
                video.LoadedBehavior = MediaState.Manual;
                //video.UnloadedBehavior = MediaState.Manual;

                video.MediaOpened += delegate
                {
                    item.Orientation = 0;
                    item.Height = 400;
                    item.Width = 700;
                };

                item.Content = video;

                if (System.IO.File.Exists(targetVideo))
                {
                    video.Source = new Uri(targetVideo);
                    video.Play();
                }
                else
                {
                    item.Content = "Video not found";
                }
            }
        }

        private void TagVisualizer_VisualizationRemoved(object sender, TagVisualizerEventArgs e)
        {
            string s = e.TagVisualization.VisualizedTag.ToString();

            if (!s.Equals("1"))
            {
                Description.Visibility = Visibility.Hidden;
            }
            if (!s.Equals("2"))
            {
                scatter.Items.Clear();
            }

        }

    }
}