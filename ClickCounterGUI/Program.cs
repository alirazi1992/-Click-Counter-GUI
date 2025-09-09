using System;
using System.Windows.Forms;

namespace ClickCounterGUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());   // If needed, use new ClickCounterGUI.Form1();
        }
    }
}
