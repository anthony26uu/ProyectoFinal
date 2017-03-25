namespace ProyectoTech.Ui.Reportes
{
    partial class ReporteFacturas
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
            this.editorialesReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // editorialesReportViewer
            // 
            this.editorialesReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorialesReportViewer.Location = new System.Drawing.Point(0, 0);
            this.editorialesReportViewer.Name = "editorialesReportViewer";
            this.editorialesReportViewer.Size = new System.Drawing.Size(692, 259);
            this.editorialesReportViewer.TabIndex = 0;
            this.editorialesReportViewer.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ReporteFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 259);
            this.Controls.Add(this.editorialesReportViewer);
            this.Name = "ReporteFacturas";
            this.Text = "ReporteFacturas";
            this.Load += new System.EventHandler(this.ReporteFacturas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer editorialesReportViewer;
    }
}