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
    public partial class FrmBaoCaoNV : Form
    {
        public FrmBaoCaoNV()
        {
            InitializeComponent();
        }

        private void FrmBaoCaoNV_Load(object sender, EventArgs e)
        {
            
        }

        private void bntTimKiem_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BaoCaoNV.Proc_BaocaoNV' table.You can move, or remove it, as needed.
            this.Proc_BaocaoNVTableAdapter.Fill(this.BaoCaoNV.Proc_BaocaoNV,txtMANV.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
