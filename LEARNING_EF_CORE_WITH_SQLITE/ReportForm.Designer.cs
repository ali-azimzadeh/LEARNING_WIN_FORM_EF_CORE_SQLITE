namespace LEARNING_EF_CORE_WITH_SQLITE
{
    partial class ReportForm
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
            reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // reportViewer
            // 
            reportViewer.AutoScroll = true;
            reportViewer.Dock = DockStyle.Fill;
            reportViewer.Location = new Point(0, 0);
            reportViewer.Name = "ReportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(396, 246);
            reportViewer.TabIndex = 0;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "ReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += ReportForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}