namespace Manajemen_Hotel3
{
    partial class Tamu
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
            panel_button = new Panel();
            btnClean = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            txtID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNama = new TextBox();
            label3 = new Label();
            txtNoTelp = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            dataGridViewTamu = new DataGridView();
            panel_button.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTamu).BeginInit();
            SuspendLayout();
            // 
            // panel_button
            // 
            panel_button.Controls.Add(btnClean);
            panel_button.Controls.Add(btnDelete);
            panel_button.Controls.Add(btnUpdate);
            panel_button.Controls.Add(btnSave);
            panel_button.Dock = DockStyle.Bottom;
            panel_button.Location = new Point(0, 552);
            panel_button.Name = "panel_button";
            panel_button.Size = new Size(1078, 92);
            panel_button.TabIndex = 0;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(490, 23);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(112, 34);
            btnClean.TabIndex = 6;
            btnClean.Text = "Clean";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(345, 23);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(192, 23);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(33, 23);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 2;
            btnSave.Text = "save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(244, 418);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 31);
            txtID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 421);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 2;
            label1.Text = "ID Tamu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 482);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 4;
            label2.Text = "Nama Lengkap";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(244, 482);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(150, 31);
            txtNama.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(447, 421);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 6;
            label3.Text = "No Telepon";
            // 
            // txtNoTelp
            // 
            txtNoTelp.Location = new Point(555, 421);
            txtNoTelp.Name = "txtNoTelp";
            txtNoTelp.Size = new Size(150, 31);
            txtNoTelp.TabIndex = 5;
            txtNoTelp.TextChanged += txtNoTelp_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(447, 485);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(555, 485);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(389, 9);
            label5.Name = "label5";
            label5.Size = new Size(253, 41);
            label5.TabIndex = 10;
            label5.Text = "Manajemen Tamu";
            label5.Click += label5_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1078, 67);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewTamu);
            panel2.Location = new Point(0, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(1078, 322);
            panel2.TabIndex = 12;
            // 
            // dataGridViewTamu
            // 
            dataGridViewTamu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTamu.Dock = DockStyle.Fill;
            dataGridViewTamu.Location = new Point(0, 0);
            dataGridViewTamu.Name = "dataGridViewTamu";
            dataGridViewTamu.RowHeadersWidth = 62;
            dataGridViewTamu.RowTemplate.Height = 33;
            dataGridViewTamu.Size = new Size(1078, 322);
            dataGridViewTamu.TabIndex = 0;
            dataGridViewTamu.CellClick += dataGridViewTamu_CellClick;
            // 
            // Tamu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 644);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtNoTelp);
            Controls.Add(label2);
            Controls.Add(txtNama);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(panel_button);
            Name = "Tamu";
            Text = "Tamu";
            Load += Tamu_Load;
            panel_button.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTamu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_button;
        private TextBox txtID;
        private Label label1;
        private Label label2;
        private TextBox txtNama;
        private Label label3;
        private TextBox txtNoTelp;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private Panel panel1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private Panel panel2;
        private Button btnClean;
        private DataGridView dataGridViewTamu;
    }
}