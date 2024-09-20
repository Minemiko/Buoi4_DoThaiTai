namespace Buoi4_DoThaiTai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<SinhVien> li_sv = new List<SinhVien>();
        List<NhanVien> li_nv = new List<NhanVien>();

        private void btnS_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien(txtHT.Text, dtpNS.Value, txtGT.Text, txtMssv.Text, txtNH.Text, 9.0);

            li_sv.Add(sv);
            dgv1.DataSource = null;
            dgv1.DataSource = li_sv;
        }

        private void btnS2_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien(txtHT2.Text,dtpNS2.Value,txtGT2.Text,txtMsnv.Text,1000000,txtCV.Text);

            li_nv.Add(nv);
            dgv2.DataSource = null;
            dgv2.DataSource = li_nv;
        }
    }
}
