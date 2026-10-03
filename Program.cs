using System.Runtime.InteropServices;
using System.Threading;

namespace frmTrackThread
{
    static class Program
    {
        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();

        [STAThread]
        static void Main()
        {
            // Open the console window
            AllocConsole();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Open the Windows Form
            Application.Run(new Form1());
        }
    }
}