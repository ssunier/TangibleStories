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

            USButton.Click += new RoutedEventHandler(USButton_Click);
            ItalyButton.Click += new RoutedEventHandler(ItalyButton_Click);
            //scatter.ItemsSource =
                //Directory.GetFiles(@"C:\Users\Public\Pictures\Sample Pictures", "*.jpg");
        }
        private void USButton_Click(object sender, RoutedEventArgs e)
        {
            scatter.ItemsSource =
                Directory.GetFiles(@"../../Resources/img/US/", "*.jpg");
            ClearButton.Visibility = Visibility.Visible;
        }
        private void CanadaButton_Click(object sender, RoutedEventArgs e)
        {
            scatter.ItemsSource =
                Directory.GetFiles(@"../../Resources/img/Canada/", "*.jpg");
            ClearButton.Visibility = Visibility.Visible;
        }
        public void TCButton_Click(object sender, RoutedEventArgs e)
        {
            scatter.ItemsSource =
                Directory.GetFiles(@"../../Resources/img/TC/", "*.jpg");
            ClearButton.Visibility = Visibility.Visible;
        }
        public void EcuadorButton_Click(object sender, RoutedEventArgs e)
        {
            scatter.ItemsSource =
                Directory.GetFiles(@"../../Resources/img/Ecuador/", "*.jpg");
            ClearButton.Visibility = Visibility.Visible;
        }
        public void PeruButton_Click(object sender, RoutedEventArgs e)
        {
            scatter.ItemsSource =
                Directory.GetFiles(@"../../Resources/img/Peru/", "*.jpg");
            ClearButton.Visibility = Visibility.Visible;
        }
        private void SwitzerlandButton_Click(object sender, RoutedEventArgs e)
        {
            scatter.ItemsSource =
                Directory.GetFiles(@"../../Resources/img/Switzerland/", "*.jpg");
            ClearButton.Visibility = Visibility.Visible;
        }
        private void AustriaButton_Click(object sender, RoutedEventArgs e)
        {
            scatter.ItemsSource =
                Directory.GetFiles(@"../../Resources/img/Austria/", "*.jpg");
            ClearButton.Visibility = Visibility.Visible;
        }
        private void FranceButton_Click(object sender, RoutedEventArgs e)
        {
            scatter.ItemsSource =
                Directory.GetFiles(@"../../Resources/img/France/", "*.jpg");
            ClearButton.Visibility = Visibility.Visible;
        }
        private void GermanyButton_Click(object sender, RoutedEventArgs e)
        {
            scatter.ItemsSource =
                Directory.GetFiles(@"../../Resources/img/Germany/", "*.jpg");
            ClearButton.Visibility = Visibility.Visible;
        }
        private void ItalyButton_Click(object sender, RoutedEventArgs e)
        {
            scatter.ItemsSource =
                Directory.GetFiles(@"../../Resources/img/Italy/", "*.jpg");
            ClearButton.Visibility = Visibility.Visible;
        }
        private void UKButton_Click(object sender, RoutedEventArgs e)
        {
            scatter.ItemsSource =
                Directory.GetFiles(@"../../Resources/img/UK/", "*.jpg");
            ClearButton.Visibility = Visibility.Visible;
        }
        private void NorwayButton_Click(object sender, RoutedEventArgs e)
        {
            scatter.ItemsSource =
                Directory.GetFiles(@"../../Resources/img/Norway/", "*.jpg");
            ClearButton.Visibility = Visibility.Visible;
        }
        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            scatter.ItemsSource = null;
            ClearButton.Visibility = Visibility.Hidden;
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
            //TODO: enable audio, animations here
        }

        /// <summary>
        /// This is called when the user can see but not interact with the application's window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnWindowNoninteractive(object sender, EventArgs e)
        {
            //TODO: Disable audio here if it is enabled

            //TODO: optionally enable animations here
        }

        /// <summary>
        /// This is called when the application's window is not visible or interactive.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnWindowUnavailable(object sender, EventArgs e)
        {
            //TODO: disable audio, animations here
        }
        private void OnItemClicked(object sender, RoutedEventArgs e)
        {
            // Get the button that was clicked & hide it.

            // Get the ScatterViewItem control for the clicked button.

            // Get the image within the ScatterViewItemcontrol

            // Convert the image to grayscale.
        }
        private void SurfaceButton_Click(object sender, RoutedEventArgs e)
        {
       
        }

        private void SurfaceWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}