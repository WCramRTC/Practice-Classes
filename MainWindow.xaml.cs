using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
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
        Car HerCar;
        Bike HerBike;
        Makeup HerTime;
        SpiritedAway Movie;
        Babbish Soup;

        // Start Notes and New Code -----------------------

        public string FormatImagePath(string imageName)
        {
            #region Step 1: File Path - Absolute vs Relative
            // Step 1 : File path
            // Absolute File path vs Relative File path
            // An absolute file path is an extremely specific file path that's about the destination. It's like a specific address in a city. If you are anywhere in the city, the address should get you there. Problem is if you are not in the city that address will break.
            // Your computer is your own city, and my computer is mine. And your image file path was an address than didn't exist in mine. So it broke.

            // Relative file path
            // So we remade it into a relative file path. It's all about where we start, and giving directions from there. Turn left, then right, make a u turn, etc...
            // Every project creates some specific folders needed to run. If we use that as the starting path then we can make our way to our images

            // Starting location - The debug folder thats made when we run the program. It gets ignored with the .gitignore. But is remade when we run the program. So there is ALWAYS a debug folder to start.
            #endregion

            // To do that we get Directory.GetCurrentDirectory()
            #region Consistent Starting Point
            // This returns C:\School\Classes\Programming_124\S23\Student_Assignments\Practice-Classes\bin\Debug\net6.0-windows
            // But GetCurrentDirectory would return your folder path automatically. 
            // This gives us a consistent starting point, no matter what computer it's on.
            #endregion
            string startingPoint = Directory.GetCurrentDirectory();

            #region Navigating to our Images director
            // To stay organized I created an Images folder in our project and placed your images in it. Now we have to get from our starting point
            // * ------------------------------------------- * Destination

            // Starting point
            // C:\School\Classes\Programming_124\S23\Student_Assignments\Practice-Classes\bin\Debug\net6.0-windows
            // When navigating folders you can add \.. to a string to go up a folder.

            // We want to get back to our Practice-Classes folder so we are going to add \.. to naivigate up a folder level. Example below
            // \Practice-Classes\bin\Debug\net6.0-windows
            // Add \..
            // Practice-Classes\bin\Debug
            // Add another \..
            // Practice-Classes\bin\
            // Add one more \..
            // Practice-Classes
            // in total
            // \Practice-Classes\bin\Debug\net6.0-windows\..\..\..
            // This places us in your Project folder. Now since we made an images folder we have to add \Images\,
            // \Practice-Classes\bin\Debug\net6.0-windows\..\..\..\Images
            // And finally we can say our image name
            // \Practice-Classes\bin\Debug\net6.0-windows\..\..\..\Images\skyandcar.jpg

            // This seems like a lot, but remember the computer is doing most of the work. Were just telling it where to go. So the result is.
            // Directory.GetDirectory + @"\..\..\..\Images\" + file;
            // Once we have that you can pass in your full path to the bitmap.

            // I made this method to reduce code and clean things up a bit.

            #endregion

            string destinationImageFolder = @"\..\..\..\Images\";
            string fullPath = startingPoint + destinationImageFolder;
            return fullPath + $"{imageName}";
        }

        // Step 2 : Another method to organize our code.
        #region Refactoring the code to display images
        // Now that we've gotten our file path ( which should be consistent. As long as we put our images in the Images folder, we can find it )
        // I took your bitmap code and refactored it. The only things that change are
        // 1. The image file name
        // 2. The image box
        // So I take both of those as parameters and just pass in the right info during the method call.
        #endregion
        public void DisplayImage(string image, Image imgBox)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            // Called our new FormatImagePath and pass in the image name
            string path = FormatImagePath(image);
            bitmap.UriSource = new Uri($@"{path}");
            bitmap.EndInit();
            // changed this to our parameter name
            imgBox.Source = bitmap;
        } // End Display Images

        // Step 3
        // Just a preload 
        public void PopulateImages()
        {
            DisplayImage("skyandcar.jpg", imgCar);
            DisplayImage("unsplashbike.jpg", imgBike);
            DisplayImage("makeupunsplash.jpg", imgMakeup);
            DisplayImage("unsplashsa.jpg", imgspirit);
            DisplayImage("soup.jpg", imgSoup);
        } // End PopulateImages

        public MainWindow()
        {
            InitializeComponent();

            // Step 4 : Called our new code
            PopulateImages();
            LoadObjects();
        } // End Main

        // Just cleaned up the global namespace
        public void LoadObjects()
        {
            HerCar = new Car("Suburu", "WRX", 2023, "Grey", 30);
            HerBike = new Bike("Trek", "Mountain Bike", "Silver & Teal", 4);
            HerTime = new Makeup("Anastasia Beverly Hills", 239, 7, "It's Theraputic and it defines self care.");
            Movie = new SpiritedAway("Sen to Chihiro no Kamikakushi", "Spirited Away", "July 20, 2001 & 125 minutes", "Family on their way to their new home. Dad takes a shortcut. Shortcut was a failed. Family finds tunnel. Both parents are curious what's in the tunnel. Child hesistant to enter. Follows her parent's anyways. Parents ended up feasting at an unknown location which transition them to pigs. Now, child must find a way to magically turn her parents back to human which lead into a whole adventure.");
            Soup = new Babbish("Potato Leek Soup", "Someone wise once said, “If you are what you eat, then I only want to eat the good stuff.” Well, we can undoubtedly confirm that this potato leek soup is definitely the good stuff. No ‘little chef’ required! ", "January 18, 2023", 1.75);

        } // Load Objects

        // End Notes and New Code -----------------------

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
