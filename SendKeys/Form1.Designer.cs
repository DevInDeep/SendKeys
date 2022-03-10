
namespace SendKeys
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCurrentlyActiveWindow = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnLock = new System.Windows.Forms.Button();
            this.lblActiveWindow = new System.Windows.Forms.Label();
            this.txtActiveWindow = new System.Windows.Forms.TextBox();
            this.txtWindowHandle = new System.Windows.Forms.TextBox();
            this.lblActiveWindowHandle = new System.Windows.Forms.Label();
            this.grpKeys = new System.Windows.Forms.GroupBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rbtALT = new System.Windows.Forms.RadioButton();
            this.rbtCTRL = new System.Windows.Forms.RadioButton();
            this.cboLetter = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.grpKeys.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCurrentlyActiveWindow});
            this.statusStrip1.Location = new System.Drawing.Point(0, 773);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(3, 0, 37, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1133, 54);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblCurrentlyActiveWindow
            // 
            this.lblCurrentlyActiveWindow.Name = "lblCurrentlyActiveWindow";
            this.lblCurrentlyActiveWindow.Size = new System.Drawing.Size(223, 41);
            this.lblCurrentlyActiveWindow.Text = "Active Window:";
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(813, 29);
            this.btnLock.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(293, 55);
            this.btnLock.TabIndex = 1;
            this.btnLock.Text = "Lock Window";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // lblActiveWindow
            // 
            this.lblActiveWindow.AutoSize = true;
            this.lblActiveWindow.Location = new System.Drawing.Point(35, 41);
            this.lblActiveWindow.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblActiveWindow.Name = "lblActiveWindow";
            this.lblActiveWindow.Size = new System.Drawing.Size(209, 32);
            this.lblActiveWindow.TabIndex = 2;
            this.lblActiveWindow.Text = "Active Window:";
            // 
            // txtActiveWindow
            // 
            this.txtActiveWindow.Location = new System.Drawing.Point(269, 33);
            this.txtActiveWindow.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtActiveWindow.Name = "txtActiveWindow";
            this.txtActiveWindow.Size = new System.Drawing.Size(521, 38);
            this.txtActiveWindow.TabIndex = 3;
            // 
            // txtWindowHandle
            // 
            this.txtWindowHandle.Location = new System.Drawing.Point(269, 95);
            this.txtWindowHandle.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtWindowHandle.Name = "txtWindowHandle";
            this.txtWindowHandle.Size = new System.Drawing.Size(185, 38);
            this.txtWindowHandle.TabIndex = 4;
            // 
            // lblActiveWindowHandle
            // 
            this.lblActiveWindowHandle.AutoSize = true;
            this.lblActiveWindowHandle.Location = new System.Drawing.Point(24, 103);
            this.lblActiveWindowHandle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblActiveWindowHandle.Name = "lblActiveWindowHandle";
            this.lblActiveWindowHandle.Size = new System.Drawing.Size(222, 32);
            this.lblActiveWindowHandle.TabIndex = 5;
            this.lblActiveWindowHandle.Text = "Window Handle:";
            // 
            // grpKeys
            // 
            this.grpKeys.Controls.Add(this.txtText);
            this.grpKeys.Controls.Add(this.btnSend);
            this.grpKeys.Controls.Add(this.rbtALT);
            this.grpKeys.Controls.Add(this.rbtCTRL);
            this.grpKeys.Controls.Add(this.cboLetter);
            this.grpKeys.Location = new System.Drawing.Point(32, 157);
            this.grpKeys.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grpKeys.Name = "grpKeys";
            this.grpKeys.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grpKeys.Size = new System.Drawing.Size(1075, 610);
            this.grpKeys.TabIndex = 6;
            this.grpKeys.TabStop = false;
            this.grpKeys.Text = "Send Keys";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(64, 141);
            this.txtText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(701, 449);
            this.txtText.TabIndex = 6;
            this.txtText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtText_KeyPress);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(565, 72);
            this.btnSend.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(200, 55);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rbtALT
            // 
            this.rbtALT.AutoSize = true;
            this.rbtALT.Location = new System.Drawing.Point(221, 79);
            this.rbtALT.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rbtALT.Name = "rbtALT";
            this.rbtALT.Size = new System.Drawing.Size(104, 36);
            this.rbtALT.TabIndex = 4;
            this.rbtALT.TabStop = true;
            this.rbtALT.Text = "ALT";
            this.rbtALT.UseVisualStyleBackColor = true;
            // 
            // rbtCTRL
            // 
            this.rbtCTRL.AutoSize = true;
            this.rbtCTRL.Location = new System.Drawing.Point(64, 79);
            this.rbtCTRL.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rbtCTRL.Name = "rbtCTRL";
            this.rbtCTRL.Size = new System.Drawing.Size(125, 36);
            this.rbtCTRL.TabIndex = 3;
            this.rbtCTRL.TabStop = true;
            this.rbtCTRL.Text = "CTRL";
            this.rbtCTRL.UseVisualStyleBackColor = true;
            // 
            // cboLetter
            // 
            this.cboLetter.FormattingEnabled = true;
            this.cboLetter.Items.AddRange(new object[] {
            "A",
            "O",
            "P",
            "F4"});
            this.cboLetter.Location = new System.Drawing.Point(357, 76);
            this.cboLetter.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cboLetter.Name = "cboLetter";
            this.cboLetter.Size = new System.Drawing.Size(185, 39);
            this.cboLetter.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 827);
            this.Controls.Add(this.grpKeys);
            this.Controls.Add(this.lblActiveWindowHandle);
            this.Controls.Add(this.txtWindowHandle);
            this.Controls.Add(this.txtActiveWindow);
            this.Controls.Add(this.lblActiveWindow);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpKeys.ResumeLayout(false);
            this.grpKeys.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentlyActiveWindow;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Label lblActiveWindow;
        private System.Windows.Forms.TextBox txtActiveWindow;
        private System.Windows.Forms.TextBox txtWindowHandle;
        private System.Windows.Forms.Label lblActiveWindowHandle;
        private System.Windows.Forms.GroupBox grpKeys;
        private System.Windows.Forms.ComboBox cboLetter;
        private System.Windows.Forms.RadioButton rbtCTRL;
        private System.Windows.Forms.RadioButton rbtALT;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtText;
    }
}

