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
using System.Windows.Shapes;

namespace EventProg_WindowManagement
{
    /// <summary>
    /// Interaction logic for NotMainWindow.xaml
    /// </summary>
    public partial class NotMainWindow : Window
    {
        public NotMainWindow()
        {
            InitializeComponent();
            if (!WindowManager.getShowNotMainWindow())
                this.Close();
        }

        public NotMainWindow(string TheString)
        {
            InitializeComponent();
            if (!WindowManager.getShowNotMainWindow())
                this.Close();

            txtbString.Text = TheString;
        }

        private void NotMain_Initialized(object sender, EventArgs e)
        {
            WindowManager.setShowNotMainWindow(true);
        }

        private void NotMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            WindowManager.setShowNotMainWindow(false);
            WindowManager.mw = new MainWindow(txtbString.Text);
            WindowManager.mw.Show();
        }
    }
}
