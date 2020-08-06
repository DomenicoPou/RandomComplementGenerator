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

        /// <summary>
        /// Main window constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event when the Main Window has loaded
        /// </summary>
        /// <param name="sender">The window</param>
        /// <param name="e">The event triggered</param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (ConfigHandler.config.name == null) HandleNameConfiguration();
        }

        /// <summary>
        /// Handles the name configuration using Name Dialog
        /// </summary>
        private void HandleNameConfiguration()
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

        /// <summary>
        /// Handles the compliment label generation
        /// </summary>
        /// <param name="sender">The button that sent the even</param>
        /// <param name="e">The event object</param>
        private void complimentButton_Click(object sender, RoutedEventArgs e)
        {
            // Set the opacity to 100
            complimentLabel.Opacity = 100;

            // Generate the compliment, and set it to the labe;
            complimentLabel.Content = ComplimentHandler.GenerateCompliment();

            // Incriment the users compliment integer, and save
            ConfigHandler.config.howMany++;
            ConfigHandler.Save();
        }
    }
}
