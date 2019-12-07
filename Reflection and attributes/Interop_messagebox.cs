using System;
using System.Runtime.InteropServices;

namespace Interop_messagebox
{
    class Program
    {
           //interop are called the operations with the library of the operation system

            [DllImport("user32.dll", EntryPoint = "MessageBox")]
        public static extern int ShowMessageBox(int hWdth, string text, string caption, int type);
        static void Main(string[] args)
        {
            ShowMessageBox(0, "Hello Students", "SoftUni", 3);

        }
    }
}
