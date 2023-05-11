
namespace QUANLYBENHVIEN
{
    partial class FrmThongTinBenhNhan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Proc_select_KHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ThongTinBenhNhan = new QUANLYBENHVIEN.ThongTinBenhNhan();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntTimKiem = new System.Windows.Forms.Button();
            this.txtMAKHOA = new System.Windows.Forms.TextBox();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Proc_select_KHOATableAdapter = new QUANLYBENHVIEN.ThongTinBenhNhanTableAdapters.Proc_select_KHOATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Proc_select_KHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongTinBenhNhan)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Proc_select_KHOABindingSource
            // 
            this.Proc_select_KHOABindingSource.DataMember = "Proc_select_KHOA";
            this.Proc_select_KHOABindingSource.DataSource = this.ThongTinBenhNhan;
            // 
            // ThongTinBenhNhan
            // 
            this.ThongTinBenhNhan.DataSetName = "ThongTinBenhNhan";
            this.ThongTinBenhNhan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.bntTimKiem);
            this.panel1.Controls.Add(this.txtMAKHOA);
            this.panel1.Controls.Add(this.lblMaKhoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 88);
            this.panel1.TabIndex = 0;
            // 
            // bntTimKiem
            // 
            this.bntTimKiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntTimKiem.Location = new System.Drawing.Point(571, 18);
            this.bntTimKiem.Name = "bntTimKiem";
            this.bntTimKiem.Size = new System.Drawing.Size(159, 47);
            this.bntTimKiem.TabIndex = 2;
            this.bntTimKiem.Text = "TÌM KIẾM";
            this.bntTimKiem.UseVisualStyleBackColor = true;
            this.bntTimKiem.Click += new System.EventHandler(this.bntTimKiem_Click);
            // 
            // txtMAKHOA
            // 
            this.txtMAKHOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAKHOA.Location = new System.Drawing.Point(202, 33);
            this.txtMAKHOA.Name = "txtMAKHOA";
            this.txtMAKHOA.Size = new System.Drawing.Size(201, 30);
            this.txtMAKHOA.TabIndex = 1;
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhoa.Location = new System.Drawing.Point(51, 32);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(97, 27);
            this.lblMaKhoa.TabIndex = 0;
            this.lblMaKhoa.Text = "Mã khoa";
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.CadetBlue;
            reportDataSource1.Name = "ThongTinBenhNhan";
            reportDataSource1.Value = this.Proc_select_KHOABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QUANLYBENHVIEN.ThongTinBenhNhan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 85);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(894, 614);
            this.reportViewer1.TabIndex = 1;
            // 
            // Proc_select_KHOATableAdapter
            // 
            this.Proc_select_KHOATableAdapter.ClearBeforeFill = true;
            // 
            // FrmThongTinBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 699);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmThongTinBenhNhan";
            this.Text = "FrmThongTinBenhNhan";
            this.Load += new System.EventHandler(this.FrmThongTinBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Proc_select_KHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongTinBenhNhan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntTimKiem;
        private System.Windows.Forms.TextBox txtMAKHOA;
        private System.Windows.Forms.Label lblMaKhoa;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Proc_select_KHOABindingSource;
        private ThongTinBenhNhan ThongTinBenhNhan;
        private ThongTinBenhNhanTableAdapters.Proc_select_KHOATableAdapter Proc_select_KHOATableAdapter;
    }
}