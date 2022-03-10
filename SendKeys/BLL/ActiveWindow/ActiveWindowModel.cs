using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendKeys.BLL.ActiveWindow
{
    public class ActiveWindowModel
    {
        public IntPtr WindowHandle { get; private set; } = IntPtr.Zero;
        public string WindowTitle { get; private set; } = string.Empty;

        private ActiveWindowModel(IntPtr windowHandle, string windowTitle)
        {
            this.WindowHandle = windowHandle;
            this.WindowTitle = windowTitle;
        }

        public void IsDifferentThan(ActiveWindowModel otherActiveWindow, Action onDifferent)
        {
            if (otherActiveWindow.WindowHandle == this.WindowHandle) return;
            onDifferent();
        }

        public static ActiveWindowModel Create(IntPtr windowHandle, string windowTitle) =>
            new ActiveWindowModel(windowHandle, windowTitle);

        public static ActiveWindowModel CreateFrom(ActiveWindowModel activeWindow) =>
            new ActiveWindowModel(activeWindow.WindowHandle, activeWindow.WindowTitle);

        public static ActiveWindowModel CreateEmpty() =>
            new ActiveWindowModel(IntPtr.Zero, string.Empty);
    }
}
