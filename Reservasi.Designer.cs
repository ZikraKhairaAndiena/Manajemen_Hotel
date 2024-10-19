namespace Manajemen_Hotel3
{
    partial class Reservasi
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
            label2 = new Label();
            txtReservId = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label1 = new Label();
            panel_button = new Panel();
            btnClean = new Button();
            dataGridView_reservasi = new DataGridView();
            txtIdTamu = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBoxNoKamar = new ComboBox();
            comboBox_tipeKamar = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            dateTimePicker_dateIn = new DateTimePicker();
            dateTimePicker_dateOut = new DateTimePicker();
            panel1.SuspendLayout();
            panel_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_reservasi).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 67);
            panel1.TabIndex = 33;
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
            label5.Size = new Size(303, 41);
            label5.TabIndex = 10;
            label5.Text = "Manajemen Reservasi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 451);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 31;
            label2.Text = "ID Tamu";
            // 
            // txtReservId
            // 
            txtReservId.Location = new Point(97, 394);
            txtReservId.Name = "txtReservId";
            txtReservId.Size = new Size(131, 31);
            txtReservId.TabIndex = 29;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(254, 26);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(632, 26);
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
            label1.Location = new Point(7, 397);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 30;
            label1.Text = "Reserv Id";
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
            panel_button.Size = new Size(895, 92);
            panel_button.TabIndex = 28;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(438, 26);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(112, 34);
            btnClean.TabIndex = 6;
            btnClean.Text = "Clean";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // dataGridView_reservasi
            // 
            dataGridView_reservasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_reservasi.Location = new Point(0, 63);
            dataGridView_reservasi.Name = "dataGridView_reservasi";
            dataGridView_reservasi.RowHeadersWidth = 62;
            dataGridView_reservasi.RowTemplate.Height = 33;
            dataGridView_reservasi.Size = new Size(895, 325);
            dataGridView_reservasi.TabIndex = 35;
            dataGridView_reservasi.CellClick += dataGridView_reservasi_CellClick;
            // 
            // txtIdTamu
            // 
            txtIdTamu.Location = new Point(97, 449);
            txtIdTamu.Name = "txtIdTamu";
            txtIdTamu.Size = new Size(131, 31);
            txtIdTamu.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 448);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 38;
            label3.Text = "Tipe Kamar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(233, 394);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 37;
            label4.Text = "No Kamar";
            // 
            // comboBoxNoKamar
            // 
            comboBoxNoKamar.FormattingEnabled = true;
            comboBoxNoKamar.Location = new Point(341, 394);
            comboBoxNoKamar.Name = "comboBoxNoKamar";
            comboBoxNoKamar.Size = new Size(147, 33);
            comboBoxNoKamar.TabIndex = 39;
            comboBoxNoKamar.SelectedIndexChanged += comboBoxNoKamar_SelectedIndexChanged;
            // 
            // comboBox_tipeKamar
            // 
            comboBox_tipeKamar.FormattingEnabled = true;
            comboBox_tipeKamar.Location = new Point(341, 451);
            comboBox_tipeKamar.Name = "comboBox_tipeKamar";
            comboBox_tipeKamar.Size = new Size(147, 33);
            comboBox_tipeKamar.TabIndex = 40;
            comboBox_tipeKamar.SelectedIndexChanged += comboBox_tipeKamar_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(493, 451);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 42;
            label6.Text = "Date Out";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(494, 397);
            label7.Name = "label7";
            label7.Size = new Size(69, 25);
            label7.TabIndex = 41;
            label7.Text = "Date In";
            label7.Click += label7_Click;
            // 
            // dateTimePicker_dateIn
            // 
            dateTimePicker_dateIn.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_dateIn.Format = DateTimePickerFormat.Custom;
            dateTimePicker_dateIn.Location = new Point(583, 394);
            dateTimePicker_dateIn.Name = "dateTimePicker_dateIn";
            dateTimePicker_dateIn.Size = new Size(300, 31);
            dateTimePicker_dateIn.TabIndex = 43;
            // 
            // dateTimePicker_dateOut
            // 
            dateTimePicker_dateOut.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_dateOut.Format = DateTimePickerFormat.Custom;
            dateTimePicker_dateOut.Location = new Point(583, 449);
            dateTimePicker_dateOut.Name = "dateTimePicker_dateOut";
            dateTimePicker_dateOut.Size = new Size(300, 31);
            dateTimePicker_dateOut.TabIndex = 44;
            // 
            // Reservasi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 588);
            Controls.Add(dateTimePicker_dateOut);
            Controls.Add(dateTimePicker_dateIn);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(comboBox_tipeKamar);
            Controls.Add(comboBoxNoKamar);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtIdTamu);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(txtReservId);
            Controls.Add(label1);
            Controls.Add(panel_button);
            Controls.Add(dataGridView_reservasi);
            Name = "Reservasi";
            Text = "Reservasi";
            Load += Reservasi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_reservasi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Label label2;
        private TextBox txtReservId;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label1;
        private Panel panel_button;
        private Button btnClean;
        private DataGridView dataGridView_reservasi;
        private TextBox txtIdTamu;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxNoKamar;
        private ComboBox comboBox_tipeKamar;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePicker_dateIn;
        private DateTimePicker dateTimePicker_dateOut;
    }
}