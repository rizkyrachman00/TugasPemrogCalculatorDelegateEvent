namespace Tugas8Calculator
{
    public partial class FrmHasil : Form
    {
        //deklarasi collection untuk menampung objek kalkulator
        private IList<Calculator> listOfHasil=new List<Calculator>();

        public FrmHasil()
        {
            InitializeComponent();
        }

        // method event handler untuk merespon event OnCreate,
        // ketika di panggil dari form entry mahasiswa
        private void FrmEntry_OnCreate(Calculator clc)
        {
            // tambahkan objek mhs yang baru ke dalam collection
            listOfHasil.Add(clc);
            int noUrut = lstHasil.Items.Count + 1;
            // tampilkan data mhs yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());

            item.SubItems.Add(clc.Penjumlahan);
            
            lstHasil.Items.Add(item);
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            // buat objek form input perhitungan
            FrmInputPerhitungan frmInput= new FrmInputPerhitungan("Hitung");
            // mendaftarkan method event handler utk merespon event OnCreate (subscribe)

            frmInput.OnCreate += FrmEntry_OnCreate;
            // tampilkan form entry mahasiswa
            frmInput.ShowDialog();
        }
    }
}