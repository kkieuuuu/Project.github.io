using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBENHVIEN
{
    public partial class FrmThongTinBenhNhan : Form
    {
        public FrmThongTinBenhNhan()
        {
            InitializeComponent();
        }

        private void FrmThongTinBenhNhan_Load(object sender, EventArgs e)
        {
            
        }

        private void bntTimKiem_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ThongTinBenhNhan.Proc_select_KHOA' table. You can move, or remove it, as needed.
            this.Proc_select_KHOATableAdapter.Fill(this.ThongTinBenhNhan.Proc_select_KHOA,txtMAKHOA.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
