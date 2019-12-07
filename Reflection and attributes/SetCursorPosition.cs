using System;
using System.Runtime.InteropServices;

namespace SetCursorPosition
{
    class Program
    {
        //Sets the cursors position at 0,0 coordinates
        [DllImport("user32.dll")]
        public static extern int SetCursorPos(int x, int y);
        static void Main(string[] args)
        {
            SetCursorPos(0, 0);
        }
    }
}
