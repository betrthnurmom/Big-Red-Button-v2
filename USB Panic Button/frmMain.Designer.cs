namespace BP.Classes
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cmdTest = new System.Windows.Forms.Button();
            this.cmdSoundClear = new System.Windows.Forms.Button();
            this.cmdCommandClear = new System.Windows.Forms.Button();
            this.cmdPictureClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdPicture = new System.Windows.Forms.Button();
            this.txtPicture = new System.Windows.Forms.TextBox();
            this.chkEarthQuake = new System.Windows.Forms.CheckBox();
            this.chkPowerPoint = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdCommand = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdWav = new System.Windows.Forms.Button();
            this.txtSound = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdTest
            // 
            this.cmdTest.Location = new System.Drawing.Point(319, 144);
            this.cmdTest.Name = "cmdTest";
            this.cmdTest.Size = new System.Drawing.Size(75, 23);
            this.cmdTest.TabIndex = 26;
            this.cmdTest.Text = "Test";
            this.cmdTest.UseVisualStyleBackColor = true;
            this.cmdTest.Click += new System.EventHandler(this.cmdTest_Click);
            // 
            // cmdSoundClear
            // 
            this.cmdSoundClear.Location = new System.Drawing.Point(346, 53);
            this.cmdSoundClear.Name = "cmdSoundClear";
            this.cmdSoundClear.Size = new System.Drawing.Size(42, 20);
            this.cmdSoundClear.TabIndex = 19;
            this.cmdSoundClear.Text = "Clear";
            this.cmdSoundClear.UseVisualStyleBackColor = true;
            // 
            // cmdCommandClear
            // 
            this.cmdCommandClear.Location = new System.Drawing.Point(346, 81);
            this.cmdCommandClear.Name = "cmdCommandClear";
            this.cmdCommandClear.Size = new System.Drawing.Size(42, 20);
            this.cmdCommandClear.TabIndex = 23;
            this.cmdCommandClear.Text = "Clear";
            this.cmdCommandClear.UseVisualStyleBackColor = true;
            // 
            // cmdPictureClear
            // 
            this.cmdPictureClear.Location = new System.Drawing.Point(346, 27);
            this.cmdPictureClear.Name = "cmdPictureClear";
            this.cmdPictureClear.Size = new System.Drawing.Size(42, 20);
            this.cmdPictureClear.TabIndex = 15;
            this.cmdPictureClear.Text = "Clear";
            this.cmdPictureClear.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Picture:";
            // 
            // cmdPicture
            // 
            this.cmdPicture.Location = new System.Drawing.Point(318, 27);
            this.cmdPicture.Name = "cmdPicture";
            this.cmdPicture.Size = new System.Drawing.Size(24, 20);
            this.cmdPicture.TabIndex = 14;
            this.cmdPicture.Text = "...";
            this.cmdPicture.UseVisualStyleBackColor = true;
            this.cmdPicture.Click += new System.EventHandler(this.cmdPicture_Click);
            // 
            // txtPicture
            // 
            this.txtPicture.Location = new System.Drawing.Point(76, 27);
            this.txtPicture.Name = "txtPicture";
            this.txtPicture.Size = new System.Drawing.Size(241, 20);
            this.txtPicture.TabIndex = 13;
            // 
            // chkEarthQuake
            // 
            this.chkEarthQuake.AutoSize = true;
            this.chkEarthQuake.Checked = true;
            this.chkEarthQuake.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEarthQuake.Location = new System.Drawing.Point(76, 132);
            this.chkEarthQuake.Name = "chkEarthQuake";
            this.chkEarthQuake.Size = new System.Drawing.Size(81, 17);
            this.chkEarthQuake.TabIndex = 25;
            this.chkEarthQuake.Text = "Earthquake";
            this.chkEarthQuake.UseVisualStyleBackColor = true;
            // 
            // chkPowerPoint
            // 
            this.chkPowerPoint.AutoSize = true;
            this.chkPowerPoint.Location = new System.Drawing.Point(76, 108);
            this.chkPowerPoint.Name = "chkPowerPoint";
            this.chkPowerPoint.Size = new System.Drawing.Size(162, 17);
            this.chkPowerPoint.TabIndex = 24;
            this.chkPowerPoint.Text = "PowerPoint next slide control";
            this.chkPowerPoint.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Command:";
            // 
            // cmdCommand
            // 
            this.cmdCommand.Location = new System.Drawing.Point(319, 81);
            this.cmdCommand.Name = "cmdCommand";
            this.cmdCommand.Size = new System.Drawing.Size(24, 20);
            this.cmdCommand.TabIndex = 22;
            this.cmdCommand.Text = "...";
            this.cmdCommand.UseVisualStyleBackColor = true;
            this.cmdCommand.Click += new System.EventHandler(this.cmdCommand_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(76, 81);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(241, 20);
            this.txtCommand.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sound File:";
            // 
            // cmdWav
            // 
            this.cmdWav.Location = new System.Drawing.Point(319, 53);
            this.cmdWav.Name = "cmdWav";
            this.cmdWav.Size = new System.Drawing.Size(24, 20);
            this.cmdWav.TabIndex = 18;
            this.cmdWav.Text = "...";
            this.cmdWav.UseVisualStyleBackColor = true;
            this.cmdWav.Click += new System.EventHandler(this.cmdWav_Click);
            // 
            // txtSound
            // 
            this.txtSound.Location = new System.Drawing.Point(76, 53);
            this.txtSound.Name = "txtSound";
            this.txtSound.Size = new System.Drawing.Size(241, 20);
            this.txtSound.TabIndex = 17;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Big Red Button";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Settings,
            this.Exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 48);
            // 
            // Settings
            // 
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(152, 22);
            this.Settings.Text = "Settings";
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(152, 22);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(416, 193);
            this.Controls.Add(this.cmdTest);
            this.Controls.Add(this.cmdSoundClear);
            this.Controls.Add(this.cmdCommandClear);
            this.Controls.Add(this.cmdPictureClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdPicture);
            this.Controls.Add(this.txtPicture);
            this.Controls.Add(this.chkEarthQuake);
            this.Controls.Add(this.chkPowerPoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdCommand);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdWav);
            this.Controls.Add(this.txtSound);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(21, 28);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Big Red Button";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdTest;
        private System.Windows.Forms.Button cmdSoundClear;
        private System.Windows.Forms.Button cmdCommandClear;
        private System.Windows.Forms.Button cmdPictureClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdPicture;
        private System.Windows.Forms.TextBox txtPicture;
        private System.Windows.Forms.CheckBox chkEarthQuake;
        private System.Windows.Forms.CheckBox chkPowerPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdCommand;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdWav;
        private System.Windows.Forms.TextBox txtSound;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Settings;
        private System.Windows.Forms.ToolStripMenuItem Exit;
    }
}

