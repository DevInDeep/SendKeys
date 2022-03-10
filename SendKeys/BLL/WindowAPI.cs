using System;
using System.Text;
using System.Runtime.InteropServices;
using SendKeys.BLL.ActiveWindow;
using SendKeys.Common;

namespace SendKeys.BLL
{
    public static class WindowAPI
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        public static void SetActiveWindow(IntPtr windowHandle) => SetForegroundWindow(windowHandle);

        public static Option<ActiveWindowModel> GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
                return Option<ActiveWindowModel>.Some(ActiveWindowModel.Create(handle, Buff.ToString()));

            return Option<ActiveWindowModel>.None();
        }

        public static void SendKeys(IntPtr windowHandle, string key)
        {
            if (SetForegroundWindow(windowHandle))
                System.Windows.Forms.SendKeys.Send(key);
        }

        public static void SendKeys(IntPtr windowHandle, bool ctrlActive, bool altActive, string key)
        {
            if (ctrlActive)
                SendKeys(windowHandle, "^{" + key.ToLower() + "}");
            else if (altActive)
                SendKeys(windowHandle, "%{" + key.ToLower() + "}");
            else
                SendKeys(windowHandle, "{" + key + "}");
        }
    }
}
