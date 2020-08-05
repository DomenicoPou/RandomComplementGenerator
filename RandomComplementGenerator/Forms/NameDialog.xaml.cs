using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RandomComplementGenerator.Forms
{
    /// <summary>
    /// Interaction logic for NameDialog.xaml
    /// </summary>
    public partial class NameDialog : Window
    {
        // Variables used for obtaining names
        private string result = "";

        /// <summary>
        /// Initial construct for Name Dialog
        /// </summary>
        public NameDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click event for the confirm button. Should close and send textbox value
        /// </summary>
        /// <param name="sender">The object sender</param>
        /// <param name="e">Event Parameter</param>
        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            result = nameTextBox.Text;
            this.Close();
        }

        /// <summary>
        /// Ignore Event for the ignore button. Should close and return empty string
        /// </summary>
        /// <param name="sender">The object sender</param>
        /// <param name="e">Event Parameter</param>
        private void ignoreButton_Click(object sender, RoutedEventArgs e)
        {
            result = "";
            this.Close();
        }
        
        /// <summary>
        /// Returns the result value. Which is set via the Name Dialog nameTextBox
        /// </summary>
        /// <returns>The nameTextBox content value</returns>
        public string GetValue()
        {
            return result;
        }
    }
}
