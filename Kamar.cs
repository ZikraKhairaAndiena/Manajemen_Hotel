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
    public partial class Kamar : Form
    {
        KelasKamar kamar = new KelasKamar();
        public Kamar()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Kamar_Load(object sender, EventArgs e)
        {
            comboBox_tipeKamar.DataSource = kamar.getTipeKamar();
            comboBox_tipeKamar.DisplayMember = "Label";
            comboBox_tipeKamar.ValueMember = "KategoriId";

            getKamarList();
            dataGridView_kamar.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string no = txtNo.Text;
            int tipe = Convert.ToInt32(comboBox_tipeKamar.SelectedValue.ToString());
            string status = rbKosong.Checked ? "Free" : "Busy";

            try
            {
                if (kamar.addKamar(no, tipe, status))
                {
                    MessageBox.Show("Room Added Successfully", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getKamarList();
                    btnClean.PerformClick();
                }
                else
                {
                    MessageBox.Show("Room Not Added", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtNo.Clear();
            comboBox_tipeKamar.SelectedIndex = 0;
        }

        private void getKamarList()
        {
            dataGridView_kamar.DataSource = kamar.getKamarList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string no = txtNo.Text;
            int tipe = Convert.ToInt32(comboBox_tipeKamar.SelectedValue.ToString());
            string status = rbKosong.Checked ? "Free" : "Busy";

            try
            {
                if (kamar.editKamar(no, tipe, status))
                {
                    MessageBox.Show("Room Update Successfully", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getKamarList();
                    btnClean.PerformClick();
                }
                else
                {
                    MessageBox.Show("Room Not Update", "Update Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_kamar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNo.Text = dataGridView_kamar.CurrentRow.Cells[0].Value.ToString();
            comboBox_tipeKamar.SelectedValue = dataGridView_kamar.CurrentRow.Cells[1].Value.ToString();
            string rButton = dataGridView_kamar.CurrentRow.Cells[2].Value.ToString();
            if (rButton.Equals("Free"))
            {
                rbKosong.Checked = true;
            }
            else
            {
                rbPenuh.Checked = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtNo.Text == "")
            {
                MessageBox.Show("Required Field - room no ", "Required failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string id = txtNo.Text;
                    Boolean deleteTamu = kamar.removeKamar(id);
                    if (deleteTamu)
                    {
                        MessageBox.Show("Room remove successfully", "Room removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getKamarList();
                        btnClean.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Error - room not remove", "error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
