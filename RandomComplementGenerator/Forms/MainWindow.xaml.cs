using RandomComplementGenerator.Forms;
using RandomComplementGenerator.Handlers;
using RandomComplementGenerator.Models;
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

namespace RandomComplementGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (ConfigHandler.config.name == null) HandleName\Configuration();
        }

        /// <summary>
        /// Handles the name configuration using Name Dialog
        /// </summary>
        private void HandleName\Configuration()
        {
            // Show the Name Dialog window
            NameDialog nameDialog = new NameDialog();
            nameDialog.ShowDialog();

            // Get the results of the window and set the name
            string results = nameDialog.GetValue();
            ConfigHandler.config.name = results;

            // Save Configuration
            ConfigHandler.Save();
        }

        private void complimentButton_Click(object sender, RoutedEventArgs e)
        {
            complimentLabel.Opacity = 100;
            complimentLabel.Content = ComplimentHandler.GenerateCompliment();
            ConfigHandler.config.howMany++;
            ConfigHandler.Save();
        }
    }
}
