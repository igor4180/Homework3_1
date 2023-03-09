using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeMessageBox
{
    internal class Program
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, uint code, string attr1, string attr2);
        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr hWnd, string attr1, string attr2, uint code = 0x0);
        static void Main(string[] args)
        {
            MessageBox(IntPtr.Zero, "Игорь", "имя");
            MessageBox(IntPtr.Zero, "Бесклеткин", "фамилия");
            MessageBox(IntPtr.Zero, "студент", "должность");
        }
    }
}
