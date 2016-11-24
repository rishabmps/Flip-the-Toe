using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Tictac_version1._0
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
            Data.Text = "Play the most addicting game with a twist." + "\n\n" + "Winning condition: \nFill the row, column, diagonal with same tiles. " + " \n\nTwist: \nYou can rotate the box in either direction and then all mighty gravity will play her part. \n\nRules: \n1.Player cannot rotate more than 2 times consecutively. \n2.No more rules just enjoy the game.";
        }
    }
}