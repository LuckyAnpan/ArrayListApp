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

        private void btnShowAll_Click(object sender, RoutedEventArgs e)
        {
            //Sort
            arrayList.Sort();

            //Show data
            //MessageBox.Show(arrayList[0].ToString());

            foreach(string data in arrayList)
            {
                MessageBox.Show(data);
            }

            //Count
            MessageBox.Show("Count " + arrayList.Count.ToString());
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //Add data
            arrayList.Add(txtName.Text);

            //Clear Textbox
            txtName.Clear();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            //Remove input object
            arrayList.Remove(txtName.Text);

            //Clear Textbox
            txtName.Clear();

            //Remove input index
            //arrayList.RemoveAt(0);

            //Remove All
            //arrayList.Clear();
        }
    }
}
