namespace Manajemen_Hotel3
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            btnLogout = new Button();
            btnKamar = new Button();
            btnReservasi = new Button();
            btnTamu = new Button();
            btnDashboard = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel_main = new Panel();
            panel_slide = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnKamar);
            panel1.Controls.Add(btnReservasi);
            panel1.Controls.Add(btnTamu);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 644);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(37, 511);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnKamar
            // 
            btnKamar.Location = new Point(37, 409);
            btnKamar.Name = "btnKamar";
            btnKamar.Size = new Size(112, 34);
            btnKamar.TabIndex = 2;
            btnKamar.Text = "Kamar";
            btnKamar.UseVisualStyleBackColor = true;
            btnKamar.Click += btnKamar_Click;
            // 
            // btnReservasi
            // 
            btnReservasi.Location = new Point(37, 319);
            btnReservasi.Name = "btnReservasi";
            btnReservasi.Size = new Size(112, 34);
            btnReservasi.TabIndex = 3;
            btnReservasi.Text = "Reservasi";
            btnReservasi.UseVisualStyleBackColor = true;
            btnReservasi.Click += btnReservasi_Click;
            // 
            // btnTamu
            // 
            btnTamu.Location = new Point(37, 233);
            btnTamu.Name = "btnTamu";
            btnTamu.Size = new Size(112, 34);
            btnTamu.TabIndex = 2;
            btnTamu.Text = "Tamu";
            btnTamu.UseVisualStyleBackColor = true;
            btnTamu.Click += btnTamu_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(37, 155);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(112, 34);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(185, 124);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel_main
            // 
            panel_main.Controls.Add(panel_slide);
            panel_main.Controls.Add(pictureBox2);
            panel_main.Controls.Add(label1);
            panel_main.Dock = DockStyle.Fill;
            panel_main.Location = new Point(185, 0);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(893, 644);
            panel_main.TabIndex = 1;
            // 
            // panel_slide
            // 
            panel_slide.BackColor = SystemColors.ActiveCaptionText;
            panel_slide.Location = new Point(6, 125);
            panel_slide.Name = "panel_slide";
            panel_slide.Size = new Size(14, 105);
            panel_slide.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pexels_pixabay_237371;
            pictureBox2.Location = new Point(26, 125);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(849, 297);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(262, 41);
            label1.Name = "label1";
            label1.Size = new Size(378, 41);
            label1.TabIndex = 0;
            label1.Text = "Hotel Management System";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 644);
            Controls.Add(panel_main);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_main.ResumeLayout(false);
            panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel_main;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button btnKamar;
        private Button btnReservasi;
        private Button btnTamu;
        private Button btnDashboard;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel_slide;
        private Button btnLogout;
    }
}