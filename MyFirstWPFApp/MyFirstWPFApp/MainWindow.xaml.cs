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

namespace MyFirstWPFApp
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

       

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Title = "As you see this button changes the name of the app";


        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            hey.Background = Brushes.Red;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            comboBox.Items.Add(textBox.Text);
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            this.Title = "Checked";
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Title = "Unchecked";
        }

        private void StatusBar_TextInput(object sender, TextCompositionEventArgs e)
        {
            
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var picker = sender as DatePicker;
            DateTime? date = picker.SelectedDate;
            if(date == null)
            {
                this.Title = "Noe Date";
            }
            else
            {
                this.Title = date.Value.ToShortDateString();
            }
        }

       
    }

       
    }

