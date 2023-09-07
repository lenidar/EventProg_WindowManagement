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

namespace EventProg_WindowManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //MessageBox.Show(WindowManager.getShowMainWindow().ToString());

            //MessageBox.Show("Main Window Default pre initial");
            InitializeComponent();
            //MessageBox.Show("Main Window Default post initial");
            if (!WindowManager.getShowMainWindow())
                this.Close();
        }

        public MainWindow(string TheString)
        {
            InitializeComponent();
            //MessageBox.Show("Main Window Default post initial");
            if (!WindowManager.getShowMainWindow())
                this.Close();

            txtbString.Text = TheString;
        }

        private void Main_Initialized(object sender, EventArgs e)
        {
            // this triggers first
            //MessageBox.Show("Main Window Initialized");
            WindowManager.setShowMainWindow(true);
        }

        private void Main_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //MessageBox.Show("Preparing to close the window");
            //this.Hide();
            WindowManager.setShowMainWindow(false);
            WindowManager.nmw = new NotMainWindow(txtbString.Text);
            WindowManager.nmw.Show();
            //this.Close();
        }

        private void txtbString_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
