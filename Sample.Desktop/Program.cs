using Sample.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Desktop
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var myMainWindow = new MainView();
            myMainWindow.ShowDialog();
        }
    }
}
