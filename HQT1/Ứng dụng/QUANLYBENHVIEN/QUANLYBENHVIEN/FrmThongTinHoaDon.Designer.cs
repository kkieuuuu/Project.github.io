
namespace QUANLYBENHVIEN
{
    partial class FrmThongTinHoaDon
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
            this.Proc_TTHOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ThongTinHoaDon = new QUANLYBENHVIEN.ThongTinHoaDon();
            this.lblMABN = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.Button();
            this.TxtMABN = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Proc_TTHOADONTableAdapter = new QUANLYBENHVIEN.ThongTinHoaDonTableAdapters.Proc_TTHOADONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Proc_TTHOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongTinHoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Proc_TTHOADONBindingSource
            // 
            this.Proc_TTHOADONBindingSource.DataMember = "Proc_TTHOADON";
            this.Proc_TTHOADONBindingSource.DataSource = this.ThongTinHoaDon;
            // 
            // ThongTinHoaDon
            // 
            this.ThongTinHoaDon.DataSetName = "ThongTinHoaDon";
            this.ThongTinHoaDon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMABN
            // 
            this.lblMABN.AutoSize = true;
            this.lblMABN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMABN.Location = new System.Drawing.Point(70, 38);
            this.lblMABN.Name = "lblMABN";
            this.lblMABN.Size = new System.Drawing.Size(150, 27);
            this.lblMABN.TabIndex = 0;
            this.lblMABN.Text = "Mã bệnh nhân";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(561, 24);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(154, 46);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.Text = "TÌM KIẾM";
            this.txtTimKiem.UseVisualStyleBackColor = false;
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            // 
            // TxtMABN
            // 
            this.TxtMABN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMABN.Location = new System.Drawing.Point(238, 35);
            this.TxtMABN.Name = "TxtMABN";
            this.TxtMABN.Size = new System.Drawing.Size(217, 34);
            this.TxtMABN.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblMABN);
            this.panel1.Controls.Add(this.TxtMABN);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 88);
            this.panel1.TabIndex = 3;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Teal;
            reportDataSource1.Name = "ThongTinHoaDon";
            reportDataSource1.Value = this.Proc_TTHOADONBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QUANLYBENHVIEN.ThongTinHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 89);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1031, 525);
            this.reportViewer1.TabIndex = 4;
            // 
            // Proc_TTHOADONTableAdapter
            // 
            this.Proc_TTHOADONTableAdapter.ClearBeforeFill = true;
            // 
            // FrmThongTinHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 610);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmThongTinHoaDon";
            this.Text = "FrmThông Tin Hóa Đơn";
            ((System.ComponentModel.ISupportInitialize)(this.Proc_TTHOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongTinHoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMABN;
        private System.Windows.Forms.Button txtTimKiem;
        private System.Windows.Forms.TextBox TxtMABN;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Proc_TTHOADONBindingSource;
        private ThongTinHoaDon ThongTinHoaDon;
        private ThongTinHoaDonTableAdapters.Proc_TTHOADONTableAdapter Proc_TTHOADONTableAdapter;
    }
}

