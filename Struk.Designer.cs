namespace Manajemen_Hotel3
{
    partial class Struk
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
            label1 = new Label();
            label2 = new Label();
            txtIdTamu = new TextBox();
            txtNama = new TextBox();
            label3 = new Label();
            txtNoTelp = new TextBox();
            label4 = new Label();
            txtTipe = new TextBox();
            label5 = new Label();
            txtHari = new TextBox();
            label6 = new Label();
            txtJumlah = new TextBox();
            label7 = new Label();
            txtReservasiId = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 19);
            label1.Name = "label1";
            label1.Size = new Size(169, 25);
            label1.TabIndex = 0;
            label1.Text = "Struk Hotel De Luna";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 131);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 1;
            label2.Text = "Id Tamu";
            // 
            // txtIdTamu
            // 
            txtIdTamu.Location = new Point(175, 131);
            txtIdTamu.Name = "txtIdTamu";
            txtIdTamu.Size = new Size(249, 31);
            txtIdTamu.TabIndex = 2;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(175, 195);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(249, 31);
            txtNama.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 195);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 3;
            label3.Text = "Nama";
            // 
            // txtNoTelp
            // 
            txtNoTelp.Location = new Point(175, 260);
            txtNoTelp.Name = "txtNoTelp";
            txtNoTelp.Size = new Size(249, 31);
            txtNoTelp.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 260);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 5;
            label4.Text = "No Telepon";
            // 
            // txtTipe
            // 
            txtTipe.Location = new Point(175, 325);
            txtTipe.Name = "txtTipe";
            txtTipe.Size = new Size(249, 31);
            txtTipe.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 325);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 7;
            label5.Text = "Tipe Kamar";
            // 
            // txtHari
            // 
            txtHari.Location = new Point(175, 384);
            txtHari.Name = "txtHari";
            txtHari.Size = new Size(249, 31);
            txtHari.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 384);
            label6.Name = "label6";
            label6.Size = new Size(104, 25);
            label6.TabIndex = 9;
            label6.Text = "Jumlah Hari";
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(175, 445);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(249, 31);
            txtJumlah.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 445);
            label7.Name = "label7";
            label7.Size = new Size(97, 25);
            label7.TabIndex = 11;
            label7.Text = "Total Bayar";
            // 
            // txtReservasiId
            // 
            txtReservasiId.Location = new Point(175, 80);
            txtReservasiId.Name = "txtReservasiId";
            txtReservasiId.Size = new Size(249, 31);
            txtReservasiId.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(58, 80);
            label8.Name = "label8";
            label8.Size = new Size(105, 25);
            label8.TabIndex = 13;
            label8.Text = "Id Reservasi";
            // 
            // Struk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 550);
            Controls.Add(txtReservasiId);
            Controls.Add(label8);
            Controls.Add(txtJumlah);
            Controls.Add(label7);
            Controls.Add(txtHari);
            Controls.Add(label6);
            Controls.Add(txtTipe);
            Controls.Add(label5);
            Controls.Add(txtNoTelp);
            Controls.Add(label4);
            Controls.Add(txtNama);
            Controls.Add(label3);
            Controls.Add(txtIdTamu);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Struk";
            Text = "Struk";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtIdTamu;
        private TextBox txtNama;
        private Label label3;
        private TextBox txtNoTelp;
        private Label label4;
        private TextBox txtTipe;
        private Label label5;
        private TextBox txtHari;
        private Label label6;
        private TextBox txtJumlah;
        private Label label7;
        private TextBox txtReservasiId;
        private Label label8;
    }
}