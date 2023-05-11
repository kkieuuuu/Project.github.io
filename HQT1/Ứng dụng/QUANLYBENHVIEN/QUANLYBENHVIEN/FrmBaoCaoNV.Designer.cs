
namespace QUANLYBENHVIEN
{
    partial class FrmBaoCaoNV
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
            this.Proc_BaocaoNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaoCaoNV = new QUANLYBENHVIEN.BaoCaoNV();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.bntTimKiem = new System.Windows.Forms.Button();
            this.lblMANV = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Proc_BaocaoNVTableAdapter = new QUANLYBENHVIEN.BaoCaoNVTableAdapters.Proc_BaocaoNVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Proc_BaocaoNVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoNV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Proc_BaocaoNVBindingSource
            // 
            this.Proc_BaocaoNVBindingSource.DataMember = "Proc_BaocaoNV";
            this.Proc_BaocaoNVBindingSource.DataSource = this.BaoCaoNV;
            // 
            // BaoCaoNV
            // 
            this.BaoCaoNV.DataSetName = "BaoCaoNV";
            this.BaoCaoNV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.txtMANV);
            this.panel1.Controls.Add(this.bntTimKiem);
            this.panel1.Controls.Add(this.lblMANV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 78);
            this.panel1.TabIndex = 0;
            // 
            // txtMANV
            // 
            this.txtMANV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMANV.Location = new System.Drawing.Point(215, 21);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(168, 34);
            this.txtMANV.TabIndex = 2;
            // 
            // bntTimKiem
            // 
            this.bntTimKiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntTimKiem.Location = new System.Drawing.Point(558, 16);
            this.bntTimKiem.Name = "bntTimKiem";
            this.bntTimKiem.Size = new System.Drawing.Size(165, 43);
            this.bntTimKiem.TabIndex = 1;
            this.bntTimKiem.Text = "TÌM KIẾM ";
            this.bntTimKiem.UseVisualStyleBackColor = true;
            this.bntTimKiem.Click += new System.EventHandler(this.bntTimKiem_Click);
            // 
            // lblMANV
            // 
            this.lblMANV.AutoSize = true;
            this.lblMANV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMANV.Location = new System.Drawing.Point(56, 24);
            this.lblMANV.Name = "lblMANV";
            this.lblMANV.Size = new System.Drawing.Size(144, 27);
            this.lblMANV.TabIndex = 0;
            this.lblMANV.Text = "Mã nhân viên";
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.LightSeaGreen;
            reportDataSource1.Name = "BaoCaoNV";
            reportDataSource1.Value = this.Proc_BaocaoNVBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QUANLYBENHVIEN.BaoCaoNV.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-9, 66);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1056, 635);
            this.reportViewer1.TabIndex = 1;
            // 
            // Proc_BaocaoNVTableAdapter
            // 
            this.Proc_BaocaoNVTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBaoCaoNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 695);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBaoCaoNV";
            this.Text = "FrmBaoCaoNV";
            this.Load += new System.EventHandler(this.FrmBaoCaoNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Proc_BaocaoNVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoNV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.Button bntTimKiem;
        private System.Windows.Forms.Label lblMANV;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Proc_BaocaoNVBindingSource;
        private BaoCaoNV BaoCaoNV;
        private BaoCaoNVTableAdapters.Proc_BaocaoNVTableAdapter Proc_BaocaoNVTableAdapter;
    }
}