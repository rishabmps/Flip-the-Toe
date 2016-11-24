using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Tictac_version1._0.Resources;
using System.Windows.Media;

namespace Tictac_version1._0
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Boolean variables to track whose move it is and if the game is over
        Boolean isX, GameOver;
        // An array to track the contents of each box (0 = empty 1 = X 2 = O)
        int[,] boxValue;
        int t = 0;
        // Helpful images
        Image myXImage, myOimage, myEmptyImage;
        // Counting moves
        int MoveCount;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            boxValue = new int[3,3];
            // STore the images for use in the game
            myXImage = new Image();
            myXImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"Images/x.jpg", UriKind.RelativeOrAbsolute));
            myOimage = new Image();
            myOimage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"Images/o.jpg", UriKind.RelativeOrAbsolute));
            myEmptyImage = new Image();
            myEmptyImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"Images/empty.jpg", UriKind.RelativeOrAbsolute));
            // Set the initial state of the game board
            resetBoxes();

            // Sample code to localize the ApplicationBar
       //     BuildLocalizedApplicationBar();
        }
        // Set the initial state of the game board
        void resetBoxes()
        {

            GameOver = false;
            MoveCount = 0;

            isX = true;
            // Set all boxes to empty
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    boxValue[i,j] = 0;
                }
            }
                
            // Display empty images in all boxes on screen
            image1.Source = myEmptyImage.Source;
            image2.Source = myEmptyImage.Source;
            image3.Source = myEmptyImage.Source;
            image4.Source = myEmptyImage.Source;
            image5.Source = myEmptyImage.Source;
            image6.Source = myEmptyImage.Source;
            image7.Source = myEmptyImage.Source;
            image8.Source = myEmptyImage.Source;
            image9.Source = myEmptyImage.Source;
            GameOver = false;
            MoveCount = 0;
            textBlock1.Text = "Next Move ";
            image10.Source = myXImage.Source;

        }
        // Respond to taps on all boxes.
        // For each box:
        // Check that it is empty and only act if it is
        // Call UpdateBox to record move and return which symbol to display
        // Check for a winner
        private void image9_Tap(System.Object sender, System.Windows.Input.GestureEventArgs e)
        {
            t = 0;
            if (textBlock1.Text.Equals("No cheating allowed"))
            {
                textBlock1.Text = "Next Move";
            }
            if (GameOver)
            {
                textBlock1.Text = "Start new Game";
            }
            else if (boxValue[2,2] == 0)
            {
                boxValue[2,2] = updateBox();
                if (boxValue[2,2] == 1)
                {
                    image9.Source = myXImage.Source;
                }
                else
                {
                    image9.Source = myOimage.Source;
                }
                if (IsWinner())
                    endGame();
            }
        }
        private void image8_Tap(System.Object sender, System.Windows.Input.GestureEventArgs e)
        {
            t = 0;
            if (textBlock1.Text.Equals("No cheating allowed"))
            {
                textBlock1.Text = "Next Move";
            }
            if (GameOver)
            {
                textBlock1.Text = "Start new Game";
            }
            else if (boxValue[2,1] == 0)
            {
                boxValue[2,1] = updateBox();
                if (boxValue[2,1] == 1)
                {
                    image8.Source = myXImage.Source;
                }
                else
                {
                    image8.Source = myOimage.Source;
                }
                if (IsWinner())
                    endGame();
            }
        }
        private void image7_Tap(System.Object sender, System.Windows.Input.GestureEventArgs e)
        {
            t = 0;
            if (textBlock1.Text.Equals("No cheating allowed"))
            {
                textBlock1.Text = "Next Move";
            }
            if (GameOver)
            {
                textBlock1.Text = "Start new Game";
            }
            else if (boxValue[2,0] == 0)
            {
                boxValue[2,0] = updateBox();
                if (boxValue[2,0] == 1)
                {
                    image7.Source = myXImage.Source;
                }
                else
                {
                    image7.Source = myOimage.Source;
                }
                if (IsWinner())
                    endGame();
            }
        }
        private void image6_Tap(System.Object sender, System.Windows.Input.GestureEventArgs e)
        {
            t = 0;
            if (textBlock1.Text.Equals("No cheating allowed"))
            {
                textBlock1.Text = "Next Move";
            }
            if (GameOver)
            {
                textBlock1.Text = "Start new Game";
            }
            else if (boxValue[1,2] == 0)
            {
                boxValue[1,2] = updateBox();
                if (boxValue[1,2] == 1)
                {
                    image6.Source = myXImage.Source;
                }
                else
                {
                    image6.Source = myOimage.Source;
                }
                if (IsWinner())
                    endGame();
            }
        }
        private void image5_Tap(System.Object sender, System.Windows.Input.GestureEventArgs e)
        {
            t = 0;
            if (textBlock1.Text.Equals("No cheating allowed"))
            {
                textBlock1.Text = "Next Move";
            }
            if (GameOver)
            {
                textBlock1.Text = "Start new Game";
            }
            else if (boxValue[1,1] == 0)
            {
                boxValue[1,1] = updateBox();
                if (boxValue[1,1] == 1)
                {
                    image5.Source = myXImage.Source;
                }
                else
                {
                    image5.Source = myOimage.Source;
                }
                if (IsWinner())
                    endGame();
            }
        }
        private void image4_Tap(System.Object sender, System.Windows.Input.GestureEventArgs e)
        {
            t = 0;
            if (textBlock1.Text.Equals("No cheating allowed"))
            {
                textBlock1.Text = "Next Move";
            }
            if (GameOver)
            {
                textBlock1.Text = "Start new Game";
            }
            else if (boxValue[1,0] == 0)
            {
                boxValue[1,0] = updateBox();
                if (boxValue[1,0] == 1)
                {
                    image4.Source = myXImage.Source;
                }
                else
                {
                    image4.Source = myOimage.Source;
                }
                if (IsWinner())
                    endGame();
            }
        }
        private void image3_Tap(System.Object sender, System.Windows.Input.GestureEventArgs e)
        {
            t = 0;
            if (textBlock1.Text.Equals("No cheating allowed"))
            {
                textBlock1.Text = "Next Move";
            }
            if (GameOver)
            {
                textBlock1.Text = "Start new Game";
            }
            else if (boxValue[0,2] == 0)
            {
                boxValue[0,2] = updateBox();
                if (boxValue[0,2] == 1)
                {
                    image3.Source = myXImage.Source;
                }
                else
                {
                    image3.Source = myOimage.Source;
                }
                if (IsWinner())
                    endGame();
            }
        }
        private void image2_Tap(System.Object sender, System.Windows.Input.GestureEventArgs e)
        {
            t = 0;
            if (textBlock1.Text.Equals("No cheating allowed"))
            {
                textBlock1.Text = "Next Move";
            }
            if(GameOver){
            textBlock1.Text = "Start new Game";
             }
            else if (boxValue[0,1] == 0)
            {
                boxValue[0,1] = updateBox();
                if (boxValue[0,1] == 1)
                {
                    image2.Source = myXImage.Source;
                }
                else
                {
                    image2.Source = myOimage.Source;
                }
                if (IsWinner())
                    endGame();
            }
        }
        private void image1_Tap(System.Object sender, System.Windows.Input.GestureEventArgs e)
        {
            t = 0;
            if (textBlock1.Text.Equals("No cheating allowed"))
            {
                textBlock1.Text = "Next Move";
            }
            if (GameOver)
            {
                textBlock1.Text = "Start new Game";
            }
            else if (boxValue[0,0] == 0)
            {
                boxValue[0,0] = updateBox();
                if (boxValue[0,0] == 1)
                {
                    image1.Source = myXImage.Source;
                }
                else
                {
                    image1.Source = myOimage.Source;
                }
                if (IsWinner())
                    endGame();
            }
        }
        // Count move and determine which player made the move.
        // Display the symbol for the next player to move
        public int updateBox()
        {
            if (GameOver)
                return 0;
            MoveCount = MoveCount + 1;

            if (isX)
            {
                isX = !isX;
                image10.Source = myOimage.Source;
                return 1;
            }
            else
            {
                isX = !isX;
                image10.Source = myXImage.Source;
                return 2;
            }

        }

        // Determine if there is a winner by checking possible winning combinations
        private bool IsWinner()
        {
            bool HaveWinner = false;
            HaveWinner = false;
            if (boxValue[0,0] != 0 & boxValue[0,0] == boxValue[0,1] & boxValue[0,0] == boxValue[0,2])
                HaveWinner = true;
            if (boxValue[1,0] != 0 & boxValue[1,0] == boxValue[1,1] & boxValue[1,0] == boxValue[1,2])
                HaveWinner = true;
            if (boxValue[2,0] != 0 & boxValue[2,1] == boxValue[2,0] & boxValue[2,0] == boxValue[2,2])
                HaveWinner = true;
            if (boxValue[0,0] != 0 & boxValue[0,0] == boxValue[1,0] & boxValue[1,0] == boxValue[2,0])
                HaveWinner = true;
            if (boxValue[0,1] != 0 & boxValue[0,1] == boxValue[1,1] & boxValue[1,1] == boxValue[2,1])
                HaveWinner = true;
            if (boxValue[0,2] != 0 & boxValue[1,2] == boxValue[0,2] & boxValue[1,2] == boxValue[2,2])
                HaveWinner = true;
            if (boxValue[0,0] != 0 & boxValue[0,0] == boxValue[1,1] & boxValue[1,1] == boxValue[2,2])
                HaveWinner = true;
            if (boxValue[0,2] != 0 & boxValue[0,2] == boxValue[1,1] & boxValue[1,1] == boxValue[2,0])
                HaveWinner = true;

            if (HaveWinner == true)
                GameOver = true;
            // if there is no winner but we have taken 9 moves declare a draw (tie)
            if (MoveCount >= 9)
                TieGame();
            return HaveWinner;
        }
        // Announce the winner
        public void endGame()
        {
            textBlock1.Text = "The Winner is";
            if (isX)
            {
                image10.Source = myOimage.Source;
            }
            else
            {
                image10.Source = myXImage.Source;
            }
        }


        // Display tie game information
        public void TieGame()
        {
            image10.Source = myEmptyImage.Source;
            textBlock1.Text = "Tie Game";

        }

        private void click_left(object sender, EventArgs e)
        {
            t = t + 1;
            if (MoveCount >= 9)
            {
                TieGame();
            }
            else if  (IsWinner())
                endGame();

            
            else if (t <= 2)
            {
                rotate_left();
                gravity();

                if (IsWinner())
                    endGame();

            }
            else
            {
                textBlock1.Text = "No cheating allowed";
            }
            
        }

        private void click_new(object sender, EventArgs e)
        {
            resetBoxes();
        }

        private void click_right(object sender, EventArgs e)
        {
            t = t + 1;
            if (MoveCount >= 9)
            {
                TieGame();
            }
            else if (IsWinner())
                endGame();

            
            else if (t <= 2)
            {
                rotate_right();
                gravity();

                if (IsWinner())
                    endGame();

            }
            else
            {
                textBlock1.Text = "No cheating allowed";
            }
        }
        private void rotate_right()
        {
            int temp;
            temp = boxValue[0, 2];
            ImageSource s = image3.Source;
            boxValue[0, 2] = boxValue[0, 0];
            image3.Source = image1.Source;
            boxValue[0, 0] = boxValue[2, 0];
            image1.Source = image7.Source;
            boxValue[2, 0] = boxValue[2, 2];
            image7.Source = image9.Source;
            boxValue[2, 2] = temp;
            image9.Source = s;
            temp = boxValue[1, 0];
            s = image4.Source;
            boxValue[1, 0] = boxValue[2, 1];
            image4.Source = image8.Source;
            boxValue[2, 1] = boxValue[1, 2];
            image8.Source = image6.Source;
            boxValue[1, 2] = boxValue[0, 1];
            image6.Source = image2.Source;
            boxValue[0, 1] = temp;
            image2.Source = s;

        }
        private void rotate_left()
        {
            int temp;
            temp = boxValue[0, 2];
            ImageSource s = image3.Source;
            boxValue[0, 2] = boxValue[2, 2];
            image3.Source = image9.Source;
            boxValue[2, 2] = boxValue[2, 0];
            image9.Source = image7.Source;
            boxValue[2, 0] = boxValue[0, 0];
            image7.Source = image1.Source;
            boxValue[0, 0] = temp;
            image1.Source = s;
            temp = boxValue[1, 0];
            s = image4.Source;
            boxValue[1, 0] = boxValue[0, 1];
            image4.Source = image2.Source;
            boxValue[0, 1] = boxValue[1, 2];
            image2.Source = image6.Source;
            boxValue[1, 2] = boxValue[2, 1];
            image6.Source = image8.Source;
            boxValue[2, 1] = temp;
            image8.Source = s;
        }
        private void gravity(){
            if (boxValue[2, 0] == 0)
            {
                if (boxValue[1, 0] == 0)
                {
                    boxValue[2, 0] = boxValue[0, 0];
                    image7.Source = image1.Source;
                    boxValue[0, 0] = 0;
                    image1.Source = myEmptyImage.Source;
                }
                else
                {
                    boxValue[2, 0] = boxValue[1, 0];
                    image7.Source = image4.Source;
                    boxValue[1, 0] = boxValue[0, 0];
                    image4.Source = image1.Source;
                    boxValue[0, 0] = 0;
                    image1.Source = myEmptyImage.Source;
                }
                
            }
            else if (boxValue[1, 0] == 0)
            {
                boxValue[1, 0] = boxValue[0, 0];
                image4.Source = image1.Source;
                boxValue[0, 0] = 0;
                image1.Source = myEmptyImage.Source;
            }
            if (boxValue[2, 1] == 0)
            {
                if (boxValue[1, 1] == 0)
                {
                    boxValue[2, 1] = boxValue[0, 1];
                    image8.Source = image2.Source;
                    boxValue[0, 1] = 0;
                    image2.Source = myEmptyImage.Source;
                }
                else
                {
                    boxValue[2, 1] = boxValue[1, 1];
                    image8.Source = image5.Source;
                    boxValue[1, 1] = boxValue[0, 1];
                    image5.Source = image2.Source;
                    boxValue[0, 1] = 0;
                    image2.Source = myEmptyImage.Source;
                }

            }
            else if (boxValue[1, 1] == 0)
            {
                boxValue[1, 1] = boxValue[0, 1];
                image5.Source = image2.Source;
                boxValue[0, 1] = 0;
                image2.Source = myEmptyImage.Source;
            }
            if (boxValue[2, 2] == 0)
            {
                if (boxValue[1, 2] == 0)
                {
                    boxValue[2, 2] = boxValue[0, 2];
                    image9.Source = image3.Source;
                    boxValue[0, 2] = 0;
                    image3.Source = myEmptyImage.Source;
                }
                else
                {
                    boxValue[2, 2] = boxValue[1, 2];
                    image9.Source = image6.Source;
                    boxValue[1, 2] = boxValue[0, 2];
                    image6.Source = image3.Source;
                    boxValue[0, 2] = 0;
                    image3.Source = myEmptyImage.Source;
                }

            }
            else if (boxValue[1, 2] == 0)
            {
                boxValue[1, 2] = boxValue[0, 2];
                image6.Source = image3.Source;
                boxValue[0, 2] = 0;
                image3.Source = myEmptyImage.Source;
            }
         }

        private void about(object sender, EventArgs e)
        {
            
            NavigationService.Navigate(new Uri("/Page1.xaml",UriKind.Relative));
        }

        private void hello(object sender, EventArgs e)
        {
             NavigationService.Navigate(new Uri("/Page2.xaml",UriKind.Relative));
        
        }
        //feature.calendar

        // Sample code for building a localized ApplicationBar
     //   private void BuildLocalizedApplicationBar()
      //  {
           // Set the page's ApplicationBar to a new instance of ApplicationBar.
       //     ApplicationBar = new ApplicationBar();

        //  Create a new button and set the text value to the localized string from AppResources.
    //       ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Images/back.png", UriKind.Relative));
    //       ApplicationBarIconButton appBarButton2 = new ApplicationBarIconButton(new Uri("/Images/feature.calendar.png", UriKind.Relative));
     //      ApplicationBarIconButton appBarButton3 = new ApplicationBarIconButton(new Uri("/Images/next.png", UriKind.Relative));
   //         appBarButton.Text = "FLeft";
    //        appBarButton2.Text = "NEW GAME";
   //         appBarButton3.Text = "FRight";
   //        ApplicationBar.Buttons.Add(appBarButton);
   //        ApplicationBar.Buttons.Add(appBarButton2);
   //        ApplicationBar.Buttons.Add(appBarButton3);
        //   ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
         //   ApplicationBar.MenuItems.Add(appBarMenuItem);
   //     }
    }
}