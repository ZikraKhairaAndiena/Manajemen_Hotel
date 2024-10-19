namespace Manajemen_Hotel3
{
    public partial class Struk : Form
    {
        private int reservasiId;
        private string idTamu;
        private int tipeKamar;
        private DateTime dateIn;
        private DateTime dateOut;
        private string nama;
        private string noTelp;
        private KelasReservasi reservasi;

        public Struk(int reservasiId, string idTamu, int tipeKamar, DateTime dateIn, DateTime dateOut, string nama, string noTelp)
        {
            InitializeComponent();

            reservasi = new KelasReservasi();

            this.reservasiId = reservasiId;
            this.idTamu = idTamu;
            this.tipeKamar = tipeKamar;
            this.dateIn = dateIn;
            this.dateOut = dateOut;
            this.nama = nama;
            this.noTelp = noTelp;

            txtReservasiId.Text = reservasiId.ToString();
            txtIdTamu.Text = idTamu;
            txtTipe.Text = tipeKamar.ToString();
            txtNama.Text = nama;
            txtNoTelp.Text = noTelp;

            // Menampilkan jumlah hari di TextBox
            txtHari.Text = JumlahHari().ToString();

            // Menghitung total harga dan menampilkannya di TextBox
            txtJumlah.Text = HitungTotalHarga().ToString("C");
        }

        private int JumlahHari()
        {
            try
            {
                // Hitung selisih hari
                int jumlahHari = (int)(dateOut - dateIn).TotalDays;

                return jumlahHari;
            }
            catch (Exception ex)
            {
                // Handle exception jika terjadi kesalahan saat menghitung jumlah hari
                MessageBox.Show("Error calculating the number of days: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private double HitungTotalHarga()
        {
            try
            {
                // Mengambil harga tipe kamar dari database (disesuaikan dengan struktur database kamu)
                double hargaTipeKamar = reservasi.GetHarga(Convert.ToInt32(tipeKamar));

                //double hargaTipeKamar = reservasi.GetHarga(tipeKamar.Label);


                // Menghitung total harga berdasarkan jumlah hari dan harga tipe kamar
                double totalHarga = JumlahHari() * hargaTipeKamar;

                return totalHarga;
            }
            catch (Exception ex)
            {
                // Handle exception jika terjadi kesalahan saat menghitung total harga
                MessageBox.Show("Error calculating total price: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
