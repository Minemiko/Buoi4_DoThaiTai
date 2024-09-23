using System.Data;
using System.Threading.Tasks.Sources;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            double.TryParse(txtDTB.Text, out double DTB);

            SinhVien sv = new SinhVien(txtHT.Text, dtpNS.Value, txtGT.Text, txtMssv.Text, txtNH.Text, DTB);

            li_sv.Add(sv);
            dgv1.DataSource = null;
            dgv1.DataSource = li_sv;
        }

        private void btnS2_Click(object sender, EventArgs e)
        {
            Double.TryParse(txtL.Text, out double L);

            NhanVien nv = new NhanVien(txtHT2.Text, dtpNS2.Value, txtGT2.Text, txtMsnv.Text, L, txtCV.Text);

            li_nv.Add(nv);
            dgv2.DataSource = null;
            dgv2.DataSource = li_nv;
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            foreach (SinhVien i in li_sv)
            {
                if (i.Mssv == txtMssv.Text)
                {
                    i.HoTen = txtHT.Text;
                    i.NgaySinh = dtpNS.Value;
                    i.GioiTinh = txtGT.Text;
                    i.NganhHoc = txtNH.Text;
                    i.Dtb = Double.Parse(txtDTB.Text);
                }
            }
            dgv1.DataSource = null;
            dgv1.DataSource = li_sv;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            foreach (SinhVien i in li_sv)
            {
                if (i.Mssv == txtMssv.Text)
                {
                    li_sv.Remove(i);
                    break;
                }
            }
            dgv1.DataSource = null;
            dgv1.DataSource = li_sv;
        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            foreach (NhanVien i in li_nv)
            {
                if (i.Msnv == txtMsnv.Text)
                {
                    i.HoTen = txtHT2.Text;
                    i.NgaySinh = dtpNS2.Value;
                    i.GioiTinh = txtGT2.Text;
                    i.Luong = Double.Parse(txtL.Text);
                    i.ChucVu = txtCV.Text;
                }
            }
            dgv2.DataSource = null;
            dgv2.DataSource = li_nv;
        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            foreach (NhanVien i in li_nv)
            {
                if (i.Msnv == txtMsnv.Text)
                {
                    li_nv.Remove(i);
                    break;
                }
            }
            dgv2.DataSource = null;
            dgv2.DataSource = li_nv;
        }
    }
}
