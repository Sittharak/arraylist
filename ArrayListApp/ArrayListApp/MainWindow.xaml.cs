using System;
using System.Collections;
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

namespace ArrayListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void Button_Click_Show(object sender, RoutedEventArgs e)
        {
            if(arrayList.Count == 0)
            {
                MessageBox.Show("No data");
            }
            else
            {
                //Show
                foreach (string data in arrayList)
                {
                    MessageBox.Show(data);
                }
            }
            
            
            //Count
            //MessageBox.Show("Count " + arrayList.Count.ToString());

            //remove
            //arrayList.RemoveAt(2);

            //Sort
            //arrayList.Sort();

            //Delete all
            //arrayList.Clear();

        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            arrayList.Add(txtdata.Text);
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            arrayList.Remove(txtdata.Text);
        }
    }
}
