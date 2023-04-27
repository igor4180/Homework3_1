using System;

using System.Runtime.InteropServices;

using System.Windows.Forms;
using System.Diagnostics;

namespace DagtherProcess 
{
    public partial class Form1 : Form
    {
        public class DllImportExample
        {
            [DllImport("User32.dll")]
            public static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);
        }
        const uint MB_OK = 0x00000000;
        const uint MB_INFORMATION = 64;
        const uint MB_ICONERROR = 0x00000010;
        private Process myProcess;
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void buttonStartCalc_Click(object sender, EventArgs e)
        {
            try
            {
                myProcess = new Process();
                myProcess.StartInfo.FileName = "notepad.exe";
                myProcess.EnableRaisingEvents = true;
                myProcess.Exited += MyProcess_Exited;
                myProcess.Start();
            }
            catch (Exception ex)
            {
                DllImportExample.MessageBox(IntPtr.Zero, "ERROR","", MB_OK | MB_ICONERROR);
            }

        }

        private void MyProcess_Exited(object sender, EventArgs e)
        {
            DllImportExample.MessageBox(IntPtr.Zero,$"Exit time: {myProcess.ExitTime}\nExit code: {myProcess.ExitCode}","", MB_OK | MB_INFORMATION);
            myProcess.Close();
        }
    }
}
