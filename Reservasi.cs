using Org.BouncyCastle.Crypto.Macs;
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
    public partial class Reservasi : Form
    {
        KelasKamar kamar = new KelasKamar();
        KelasReservasi reservasi = new KelasReservasi();
        public Reservasi()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void Reservasi_Load(object sender, EventArgs e)
        {
            comboBox_tipeKamar.DataSource = kamar.getTipeKamar();
            comboBox_tipeKamar.DisplayMember = "Label";
            comboBox_tipeKamar.ValueMember = "KategoriId";

            int tipe = Convert.ToInt32(comboBox_tipeKamar.SelectedValue.ToString());
            comboBoxNoKamar.DataSource = reservasi.kamarByTipe(tipe);
            comboBoxNoKamar.DisplayMember = "IdKamar";
            comboBoxNoKamar.ValueMember = "IdKamar";

            dataGridView_reservasi.DefaultCellStyle.ForeColor = Color.Black;
            getReservasiTable();

        }
        public void getReservasiTable()
        {
            dataGridView_reservasi.DataSource = reservasi.getReservasi();
        }

        private void comboBoxNoKamar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_tipeKamar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // display rooms number depending on the room type 
                int tipe = Convert.ToInt32(comboBox_tipeKamar.SelectedValue.ToString());
                comboBoxNoKamar.DataSource = reservasi.kamarByTipe(tipe);
                comboBoxNoKamar.DisplayMember = "IdKamar";
                comboBoxNoKamar.ValueMember = "IdKamar";
            }
            catch (Exception ex)
            {
                //nothing 
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string IdTamu = txtIdTamu.Text;
                string NoKamar = comboBoxNoKamar.SelectedValue.ToString();
                DateTime DateIn = dateTimePicker_dateIn.Value;
                DateTime DateOut = dateTimePicker_dateOut.Value;

                if (DateIn < DateTime.Today)
                {
                    MessageBox.Show("Reservation Date in must be today of after", "invalid date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (DateOut < DateIn)
                {
                    MessageBox.Show("Reservation Date in must be today of after", "invalid date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (reservasi.addReservasi(IdTamu, NoKamar, DateIn, DateOut) && reservasi.setReservasiKamar(NoKamar, "Busy"))
                    {
                        getReservasiTable();
                        MessageBox.Show("New Reservation Add Successfully", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Reservation Not Add Successfully", "Error Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Reservation Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ReservId = Convert.ToInt32(txtReservId.Text);
            string NoKamar = comboBoxNoKamar.Text;

            try
            {
                if (reservasi.removeReservasi(ReservId) && reservasi.setReservasiKamar(NoKamar, "Free"))
                {
                    getReservasiTable();
                    MessageBox.Show("Delete Reservation Successfully", " Delete Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_reservasi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtReservId.Text = dataGridView_reservasi.CurrentRow.Cells[0].Value.ToString();
            txtIdTamu.Text = dataGridView_reservasi.CurrentRow.Cells[1].Value.ToString();

            string NoKamar = dataGridView_reservasi.CurrentRow.Cells[2].Value.ToString();
            comboBox_tipeKamar.SelectedValue = reservasi.TipeByNoKamar(NoKamar);
            comboBoxNoKamar.Text = NoKamar;

            dateTimePicker_dateIn.Text = dataGridView_reservasi.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker_dateOut.Text = dataGridView_reservasi.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtReservId.Clear();
            txtIdTamu.Clear();
            comboBoxNoKamar.SelectedValue = 1;
            dateTimePicker_dateIn.Value = DateTime.Now;
            dateTimePicker_dateOut.Value = DateTime.Now;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int ReservId = Convert.ToInt32(txtReservId.Text);
                string IdTamu = txtIdTamu.Text;
                string NoKamar = comboBoxNoKamar.SelectedValue.ToString();
                DateTime DateIn = dateTimePicker_dateIn.Value;
                DateTime DateOut = dateTimePicker_dateOut.Value;

                if (DateIn < DateTime.Today)
                {
                    MessageBox.Show("Reservation Date in must be today of after", "invalid date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (DateOut < DateIn)
                {
                    MessageBox.Show("Reservation Date in must be today of after", "invalid date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (reservasi.editReservasi(ReservId, IdTamu, NoKamar, DateIn, DateOut) && reservasi.setReservasiKamar(NoKamar, "Busy"))
                    {
                        getReservasiTable();
                        MessageBox.Show("Reservation edit Successfully", "update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Reservation Not edit Successfully", "Error update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Reservation edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
