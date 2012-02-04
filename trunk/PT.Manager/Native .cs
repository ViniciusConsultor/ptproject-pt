using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;

namespace PT.Manager
{
    public class Native
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        private const int SW_HIDE = 0;
        private const int SW_SHOWNORMAL = 1;
        private const int SW_SHOWMINIMIZED = 2;
        private const int SW_SHOWMAXIMIZED = 3;
        private const int SW_SHOWNOACTIVATE = 4;
        private const int SW_RESTORE = 9;
        private const int SW_SHOWDEFAULT = 10;

        [DllImport("user32.dll")]
        private static extern
        bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        private static bool ShowWindow(Process _Process, int nCmdShow)
        {
            return ShowWindowAsync(_Process.MainWindowHandle, nCmdShow);
        }

        public static void LoadProcessInControl(string _Process, Control _Control)
        {
            System.Diagnostics.Process p = System.Diagnostics.Process.Start(_Process);
            p.WaitForInputIdle();

            _Control.Focus();
            Native.SetParent(p.MainWindowHandle, _Control.Handle);
            ShowWindow(p, SW_SHOWMAXIMIZED);
        }
    }
}
