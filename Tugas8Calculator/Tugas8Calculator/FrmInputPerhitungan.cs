using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas8Calculator
{
    public partial class FrmInputPerhitungan : Form
    {

        // deklarasi tipe data untuk event OnCreate dan OnUpdate
        public delegate void CreateUpdateEventHandler(Calculator clc);

        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;
        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi variabel untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi variabel/objek mhs untuk meyimpan data mahasiswa
        private Calculator clc;


        // Constructor default
        public FrmInputPerhitungan()
        {
            InitializeComponent();
        }

        // Constructor untuk inisialisasi data ketika entri data baru
        public FrmInputPerhitungan(string title)
         : this()
        {
            // ganti text/judul form
            this.Text = title;
        }




        private void btnProses_Click(object sender, EventArgs e)
        {
            int NilaiA, NilaiB, Hasil;

            OnCreate(clc); // panggil event OnCreate
                           // reset form input, utk persiapan input data berikutnya

            if (cboOperasi.SelectedIndex == -1)
            {
                MessageBox.Show("Operator Belum Dipilih !!");
            }
            else if (cboOperasi.SelectedIndex == 0)
            {
                NilaiA = int.Parse(txtNilaiA.Text);
                NilaiB = int.Parse(txtNilaiB.Text);
                Hasil = NilaiA + NilaiB;
                clc.Penjumlahan = Hasil.ToString();

            }



















        }
    }
}
