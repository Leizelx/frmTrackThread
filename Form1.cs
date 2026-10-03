using System;
using System.Threading;

namespace frmTrackThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnRun_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "-Thread Starts-";
            Console.WriteLine("-Thread Starts-");

            await Task.Run(() =>
            {
                Thread threadA = new Thread(MyThreadClass.Thread1);
                Thread threadB = new Thread(MyThreadClass.Thread2);
                Thread threadC = new Thread(MyThreadClass.Thread1);
                Thread threadD = new Thread(MyThreadClass.Thread2);

                threadA.Name = "Thread A";
                threadB.Name = "Thread B";
                threadC.Name = "Thread C";
                threadD.Name = "Thread D";

                threadA.Priority = ThreadPriority.Highest;
                threadB.Priority = ThreadPriority.Normal;
                threadC.Priority = ThreadPriority.AboveNormal;
                threadD.Priority = ThreadPriority.BelowNormal;

                threadA.Start();
                threadB.Start();
                threadC.Start();
                threadD.Start();

                threadA.Join();
                threadB.Join();

                Console.WriteLine($"The thread 0x{threadA.ManagedThreadId:x} has exited with code 0 (0x0).");
                Console.WriteLine($"The thread 0x{threadC.ManagedThreadId:x} has exited with code 0 (0x0).");

                threadC.Join();
                threadD.Join();

                Console.WriteLine($"The thread 0x{threadB.ManagedThreadId:x} has exited with code 0 (0x0).");
                Console.WriteLine($"The thread 0x{threadD.ManagedThreadId:x} has exited with code 0 (0x0).");
            });
            Console.WriteLine("-End of Thread-");
            lblStatus.Text = "-End of Thread-";
        }
    }
}
