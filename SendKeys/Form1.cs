using SendKeys.BLL;
using SendKeys.BLL.ActiveWindow;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SendKeys
{
    public partial class Form1 : Form
    {
        private ActiveWindowWatcher activeWindowWatcher;
        private ActiveWindowModel activeWindow = ActiveWindowModel.CreateEmpty();

        public Form1()
        {
            InitializeComponent();
            activeWindowWatcher = new ActiveWindowWatcher(TimeSpan.FromSeconds(1));
            activeWindowWatcher.ActiveWindowChanged += ActiveWindowWatcher_ActiveWindowChanged;
            activeWindowWatcher.Start();
        }

        private void ActiveWindowWatcher_ActiveWindowChanged(object sender, ActiveWindowChangedEventArgs e)
        {
            activeWindow = ActiveWindowModel.Create(e.WindowHandle, e.WindowTitle);
            lblCurrentlyActiveWindow.Text = $"Active Window: {e.WindowTitle}";
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            activeWindowWatcher.Stop();
            txtActiveWindow.Text = activeWindow.WindowTitle;
            txtWindowHandle.Text = activeWindow.WindowHandle.ToString();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            WindowAPI.SendKeys(activeWindow.WindowHandle, rbtCTRL.Checked, rbtALT.Checked, cboLetter.Text);
        }

        private void txtText_KeyPress(object sender, KeyPressEventArgs e)
        {
            WindowAPI.SendKeys(activeWindow.WindowHandle, e.KeyChar.ToString());
            WindowAPI.SetActiveWindow(Process.GetCurrentProcess().MainWindowHandle);
        }
    }
}
