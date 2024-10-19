namespace Manajemen_Hotel3
{
    partial class Kamar
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
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtNo = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label1 = new Label();
            panel_button = new Panel();
            btnClean = new Button();
            comboBox_tipeKamar = new ComboBox();
            rbKosong = new RadioButton();
            rbPenuh = new RadioButton();
            dataGridView_kamar = new DataGridView();
            panel1.SuspendLayout();
            panel_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_kamar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(871, 67);
            panel1.TabIndex = 22;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(871, 328);
            panel2.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(296, 9);
            label5.Name = "label5";
            label5.Size = new Size(265, 41);
            label5.TabIndex = 10;
            label5.Text = "Manajemen Kamar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(443, 400);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 19;
            label3.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 454);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 17;
            label2.Text = "Tipe Kamar";
            // 
            // txtNo
            // 
            txtNo.Location = new Point(208, 397);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(182, 31);
            txtNo.TabIndex = 14;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(383, 26);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(230, 26);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(71, 26);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 400);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 15;
            label1.Text = "No Kamar";
            // 
            // panel_button
            // 
            panel_button.Controls.Add(btnClean);
            panel_button.Controls.Add(btnDelete);
            panel_button.Controls.Add(btnUpdate);
            panel_button.Controls.Add(btnAdd);
            panel_button.Dock = DockStyle.Bottom;
            panel_button.Location = new Point(0, 496);
            panel_button.Name = "panel_button";
            panel_button.Size = new Size(871, 92);
            panel_button.TabIndex = 13;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(528, 26);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(112, 34);
            btnClean.TabIndex = 6;
            btnClean.Text = "Clean";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // comboBox_tipeKamar
            // 
            comboBox_tipeKamar.FormattingEnabled = true;
            comboBox_tipeKamar.Location = new Point(208, 457);
            comboBox_tipeKamar.Name = "comboBox_tipeKamar";
            comboBox_tipeKamar.Size = new Size(182, 33);
            comboBox_tipeKamar.TabIndex = 24;
            // 
            // rbKosong
            // 
            rbKosong.AutoSize = true;
            rbKosong.Location = new Point(542, 400);
            rbKosong.Name = "rbKosong";
            rbKosong.Size = new Size(98, 29);
            rbKosong.TabIndex = 0;
            rbKosong.TabStop = true;
            rbKosong.Text = "Kosong";
            rbKosong.UseVisualStyleBackColor = true;
            // 
            // rbPenuh
            // 
            rbPenuh.AutoSize = true;
            rbPenuh.Location = new Point(542, 452);
            rbPenuh.Name = "rbPenuh";
            rbPenuh.Size = new Size(85, 29);
            rbPenuh.TabIndex = 1;
            rbPenuh.TabStop = true;
            rbPenuh.Text = "Penuh";
            rbPenuh.UseVisualStyleBackColor = true;
            // 
            // dataGridView_kamar
            // 
            dataGridView_kamar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_kamar.Location = new Point(0, 63);
            dataGridView_kamar.Name = "dataGridView_kamar";
            dataGridView_kamar.RowHeadersWidth = 62;
            dataGridView_kamar.RowTemplate.Height = 33;
            dataGridView_kamar.Size = new Size(871, 325);
            dataGridView_kamar.TabIndex = 25;
            dataGridView_kamar.CellClick += dataGridView_kamar_CellClick;

            // 
            // Kamar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 588);
            Controls.Add(dataGridView_kamar);
            Controls.Add(rbPenuh);
            Controls.Add(rbKosong);
            Controls.Add(comboBox_tipeKamar);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNo);
            Controls.Add(label1);
            Controls.Add(panel_button);
            Name = "Kamar";
            Text = "Kamar";
            Load += Kamar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_kamar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox txtNo;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label1;
        private Panel panel_button;
        private Button btnClean;
        private ComboBox comboBox_tipeKamar;
        private RadioButton rbKosong;
        private RadioButton rbPenuh;
        private Panel panel2;
        private DataGridView dataGridView_kamar;
    }
}