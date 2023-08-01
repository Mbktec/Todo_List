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

namespace Todo_App
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

        private void AddToLisBox( string item)
        {        
                LbxTasks.Items.Add(item);
                TbtInput.Text = "";
        }

        private void tbtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(TbtInput.Text.Length> 0)
            {
                BtnAdd.IsEnabled = true;
                if (e.Key == Key.Enter)
                {
                    AddToLisBox(TbtInput.Text);

                }
             
            }
            else
            {

                BtnAdd.IsEnabled = false;
            }
           
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddToLisBox(TbtInput.Text);
         
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            LbxTasks.Items.Remove(LbxTasks.SelectedItem);
            BtnDelete.IsEnabled= false;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BtnDelete.IsEnabled= true;

        }
    }
}
