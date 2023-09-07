using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProg_WindowManagement
{
    internal static class WindowManager
    {
        static private bool showMainWindow = false;
        static private bool showNotMainWindow = false;
        static public MainWindow mw = null;
        static public NotMainWindow nmw = null;

        static public bool getShowMainWindow()
        {
            return showMainWindow;
        }

        static public bool getShowNotMainWindow()
        {
            return showNotMainWindow;
        }

        static public void setShowMainWindow(bool setStatus)
        {
            showMainWindow = setStatus;
        }

        static public void setShowNotMainWindow(bool setStatus)
        {
            showNotMainWindow = setStatus;
        }
    }
}
