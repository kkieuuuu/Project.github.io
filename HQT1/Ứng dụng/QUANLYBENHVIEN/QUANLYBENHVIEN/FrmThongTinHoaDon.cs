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
    public partial class FrmThongTinHoaDon : Form
    {
        public FrmThongTinHoaDon()
        {
            InitializeComponent();
        }

        

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ThongTinHoaDon.Proc_TTHOADON' table. You can move, or remove it, as needed.
            this.Proc_TTHOADONTableAdapter.Fill(this.ThongTinHoaDon.Proc_TTHOADON, TxtMABN.Text);

            this.reportViewer1.RefreshReport();
        }

       
    }
}
