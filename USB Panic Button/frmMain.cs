using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BP.Classes
{
    public partial class frmMain : Form
    {
        private PanicButtonActions button;

        public frmMain()
        {
            InitializeComponent();
            button = new PanicButtonActions();
        }

        ~frmMain() { }

        private void cmdPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Image files (*.gif, *.jpg, *.jpeg, *.png) | *.gif;*.jpg;*.jpeg;*.png";
            fd.ShowDialog();
            if (!string.IsNullOrEmpty(fd.FileName))
                txtPicture.Text = fd.FileName;
        }

        private void cmdWav_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Wav files (*.wav) | *.wav";
            fd.ShowDialog();
            if (!string.IsNullOrEmpty(fd.FileName))
                txtSound.Text = fd.FileName;
        }

        private void cmdCommand_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            if (!string.IsNullOrEmpty(fd.FileName))
                txtCommand.Text = fd.FileName;
        }

        ///  <summary>
        ///  Perform shutdown operations.
        ///  </summary>

        private void frmMain_Closed(System.Object eventSender, System.EventArgs eventArgs)
        {
            try { SaveSettings(); }
            catch (Exception ex) { throw; }
        }

        ///  <summary>
        ///  Perform startup operations.
        ///  </summary>

        private void frmMain_Load(System.Object eventSender, System.EventArgs eventArgs)
        {
            Hide();

            notifyIcon1.Visible = true;

            try { LoadSettings(); }
            catch (Exception ex) { throw; }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
                SaveSettings();
                Hide();
                e.Cancel = true;
            }
        }

        private void cmdPictureClear_Click(object sender, EventArgs e)
        {
            txtPicture.Text = "";
        }

        private void cmdSoundClear_Click(object sender, EventArgs e)
        {
            txtSound.Text = "";
        }

        private void cmdCommandClear_Click(object sender, EventArgs e)
        {
            txtCommand.Text = "";
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
                Hide();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void LoadSettings()
        {
            Properties.Settings settings = new Properties.Settings();
            settings.Reload();
            chkEarthQuake.Checked = settings.EarthQuake;
            chkPowerPoint.Checked = settings.PowerPoint;
            txtCommand.Text = settings.Command;
            txtSound.Text = settings.SoundFile;
            txtPicture.Text = settings.Picture;
        }

        private void SaveSettings()
        {
            Properties.Settings settings = new Properties.Settings();
            settings.EarthQuake = chkEarthQuake.Checked;
            settings.PowerPoint = chkPowerPoint.Checked;
            settings.Command = txtCommand.Text;
            settings.SoundFile = txtSound.Text;
            settings.Picture = txtPicture.Text;
            settings.Save();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void cmdTest_Click(object sender, EventArgs e)
        {
            button.PressButton();
        }
    }
}
