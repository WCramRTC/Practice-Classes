using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practice_Classes
{//EDNA LYNN LAXA 
 //PROGRAMMING III 
 //APRIL 7, 2023 
 //PRACTICE - CLASSES 

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Car HerCar = new Car("Suburu", "WRX", 2023, "Grey", 30);

        Bike HerBike = new Bike("Trek", "Mountain Bike", "Silver & Teal", 4);

        Makeup HerTime = new Makeup("Anastasia Beverly Hills", 239, 7, "It's Theraputic and it defines self care.");

        SpiritedAway Movie = new SpiritedAway("Sen to Chihiro no Kamikakushi", "Spirited Away", "July 20, 2001 & 125 minutes", "Family on their way to their new home. Dad takes a shortcut. Shortcut was a failed. Family finds tunnel. Both parents are curious what's in the tunnel. Child hesistant to enter. Follows her parent's anyways. Parents ended up feasting at an unknown location which transition them to pigs. Now, child must find a way to magically turn her parents back to human which lead into a whole adventure.");

        Babbish Soup = new Babbish("Potato Leek Soup", "Someone wise once said, “If you are what you eat, then I only want to eat the good stuff.” Well, we can undoubtedly confirm that this potato leek soup is definitely the good stuff. No ‘little chef’ required! ", "January 18, 2023", 1.75); 

       

        public MainWindow()
        {
            InitializeComponent();

           //IMAGES added onto GUI 

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\School\Programming 122\Practice Classes\skyandcar.jpg");
            bitmap.EndInit();
            imgCar.Source = bitmap;

            BitmapImage bitmap2 = new BitmapImage();
            bitmap2.BeginInit();
            bitmap2.UriSource = new Uri(@"C:\School\Programming 122\Practice Classes\unsplashbike.jpg");
            bitmap2.EndInit();
            imgBike.Source = bitmap2;

            BitmapImage bitmap3 = new BitmapImage();
            bitmap3.BeginInit();
            bitmap3.UriSource = new Uri(@"C:\School\Programming 122\Practice Classes\makeupunsplash.jpg");
            bitmap3.EndInit();
            imgMakeup.Source = bitmap3;

            BitmapImage bitmap4 = new BitmapImage();
            bitmap4.BeginInit();
            bitmap4.UriSource = new Uri(@"C:\School\Programming 122\Practice Classes\unsplashsa.jpg");
            bitmap4.EndInit();
            imgspirit.Source = bitmap4;

            BitmapImage bitmap5 = new BitmapImage();
            bitmap5.BeginInit();
            bitmap5.UriSource = new Uri(@"C:\School\Programming 122\Practice Classes\soup.jpg");
            bitmap5.EndInit();
            imgSoup.Source = bitmap5;

        }

        private void btnHerCar_Click(object sender, RoutedEventArgs e) // Button  for her car , to prompt data for Class CAR 
        {
            runDisplay.Text = HerCar.ToString();
        }

        private void btnHerBike_Click(object sender, RoutedEventArgs e) // Button for her bike, prompting data for Class BIKE 
        {
            runDisplay.Text = HerBike.ToString(); 
        }

        private void btnHerTime_Click(object sender, RoutedEventArgs e) //Button for her time , prompting data for Class MAKEUP 
        {
            runDisplay.Text = HerTime.ToString(); 
        }

        private void btnThemovie_Click(object sender, RoutedEventArgs e)
        {
            runDisplay.Text = Movie.ToString(); 
        }

        private void btnSoup_Click(object sender, RoutedEventArgs e)
        {
            runDisplay.Text = Soup.ToString(); 
        }
    }
}
