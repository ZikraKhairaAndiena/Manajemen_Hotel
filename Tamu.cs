using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Manajemen_Hotel3
{
    public partial class Tamu : Form
    {
        KelasTamu tamu = new KelasTamu();
        public Tamu()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNoTelp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNama.Clear();
            txtNoTelp.Clear();
            txtEmail.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNama.Text == "" || txtNoTelp.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Required Field - Id no, nama, no telp , email :", "Required failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string id = txtID.Text;
                    string namalengkap = txtNama.Text;
                    string notelp = txtNoTelp.Text;
                    string email = txtEmail.Text;

                    Boolean insertTamu = tamu.insertTamu(id, namalengkap, notelp, email);
                    if (insertTamu)
                    {
                        MessageBox.Show("New guest Save successfully", "Guest Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTable();
                        btnClean.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Error - guest not Inserted", "error Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void Tamu_Load(object sender, EventArgs e)
        {
            dataGridViewTamu.DefaultCellStyle.ForeColor = Color.Black;
            getTable();
        }

        private void getTable()
        {
            dataGridViewTamu.DataSource = tamu.getTamu();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNama.Text == "" || txtNoTelp.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Required Field - Id no, nama, no telp , email :", "Required failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string id = txtID.Text;
                    string namalengkap = txtNama.Text;
                    string notelp = txtNoTelp.Text;
                    string email = txtEmail.Text;

                    Boolean editTamu = tamu.editTamu(id, namalengkap, notelp, email);
                    if (editTamu)
                    {
                        MessageBox.Show("Guest data update successfully", "Update succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTable();
                        btnClean.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Error - guest data not update", "error Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void dataGridViewTamu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridViewTamu.CurrentRow.Cells[0].Value.ToString();
            txtNama.Text = dataGridViewTamu.CurrentRow.Cells[1].Value.ToString();
            txtNoTelp.Text = dataGridViewTamu.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dataGridViewTamu.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Required Field - Id no ", "Required failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string id = txtID.Text;
                    Boolean deleteTamu = tamu.removeTamu(id);
                    if (deleteTamu)
                    {
                        MessageBox.Show("guest data remove successfully", "Guest removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTable();
                        btnClean.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Error - guest not remove", "error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
