using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manajemen_Hotel3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panel_slide.Height = btnDashboard.Height;
            panel_slide.Top = btnDashboard.Top;

            panel_main.Controls.Clear();
            panel_main.Controls.Add(panel_main);
        }

        private void btnTamu_Click(object sender, EventArgs e)
        {
            panel_slide.Height = btnTamu.Height;
            panel_slide.Top = btnTamu.Top;
            panel_main.Controls.Clear();
            Tamu tamu = new Tamu();
            tamu.TopLevel = false;
            tamu.Dock = DockStyle.Fill;
            tamu.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(tamu);
            tamu.Show();
        }

        private void btnReservasi_Click(object sender, EventArgs e)
        {
            panel_slide.Height = btnReservasi.Height;
            panel_slide.Top = btnReservasi.Top;
            panel_main.Controls.Clear();
            Reservasi reservasi = new Reservasi();
            reservasi.TopLevel = false;
            reservasi.Dock = DockStyle.Fill;
            reservasi.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(reservasi);
            reservasi.Show();
        }

        private void btnKamar_Click(object sender, EventArgs e)
        {
            panel_slide.Height = btnKamar.Height;
            panel_slide.Top = btnKamar.Top;
            panel_main.Controls.Clear();
            Kamar kamar = new Kamar();
            kamar.TopLevel = false;
            kamar.Dock = DockStyle.Fill;
            kamar.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(kamar);
            kamar.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            panel_slide.Height = btnLogout.Height;
            panel_slide.Top = btnLogout.Top;
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
