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

namespace MessageBoxExamples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Code to show a message box with yes, no, cancel
            MessageBoxResult mbr = MessageBox.Show("Pick a button", "Caption", MessageBoxButton.YesNoCancel);

            //MessageBoxResult is an enum - you can
            //treat the values as integers
            if (mbr == MessageBoxResult.No)
            {
                //In xaml I named the Window window
                //replace this code with what you want 
                //to happen when they click no
                window.Title = "no";
            }
            else if (mbr == MessageBoxResult.Yes) {
                window.Title = "yes";//replace with useful code
            }
            //Note: cancel was not accounted for so nothing happens.
        }
    }
}
