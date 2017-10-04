using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamCheeky;
using System.Windows.Forms;
using System.Drawing;

namespace BP.Classes
{
    public class PanicButtonActions
    {
        private BigRedButton Device = new BigRedButton();
        bool started = false;

        public PanicButtonActions()
        {
            Device.ButtonPressed += PressButton;
            Device.LidOpen += LidOpen;
            Device.LidClosed += LidClosed;
            OpenConnection();
        }

        ~PanicButtonActions()
        {
            Device.Dispose();
            started = false;
        }

        public void OpenConnection()
        {
            if (!started)
            {
                Device.Start();
                started = true;
            }
        }

        private void LidClosed(object sender, EventArgs e)
        {
            frmPicture.Dispose();
            frmPicture = null;
        }

        private void LidOpen(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }
        public void PressButton()
        {
            PressButton(null, null);
        }

        private void PressButton(object sender, EventArgs e)
        {       
            ShowPicture();
        }

        public static Form frmPicture;
        private static void ShowPicture()
        {
            Properties.Settings settings = new Properties.Settings();
            settings.Reload();

            Image _image = Image.FromFile(settings.Picture);

            // Make a Form with a PictureBox
            frmPicture = new Form();
            frmPicture.AutoSize = true;
            frmPicture.WindowState = FormWindowState.Maximized;
            frmPicture.FormBorderStyle = FormBorderStyle.None;
            frmPicture.BackColor = Color.Black;
            frmPicture.ShowInTaskbar = false;

            PictureBox _pictureBox = new PictureBox();
            _pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            _pictureBox.Width = Screen.PrimaryScreen.Bounds.Width;
            _pictureBox.Height = Screen.PrimaryScreen.Bounds.Height;
            _pictureBox.Image = _image;
            _pictureBox.Click += new EventHandler(_pictureBox_Click);
            frmPicture.Controls.Add(_pictureBox);
            frmPicture.TopMost = true;
            frmPicture.Focus();
            frmPicture.BringToFront();
            frmPicture.Show();
        }

        static void _pictureBox_Click(object sender, EventArgs e)
        {
            frmPicture.Dispose();
            frmPicture = null;
        }
    }
}
