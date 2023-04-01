
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEARNING_EF_CORE_WITH_SQLITE
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            reportViewer.LocalReport.DataSources.Clear();

            //DataSet1TableAdapters.CategoriesTableAdapter categoriesTableAdapter =
            //    new DataSet1TableAdapters.CategoriesTableAdapter();

            //DataSet1.CategoriesDataTable categories =
            //    categoriesTableAdapter.GetData();

            //ReportDataSource reportDataSource =
            //    new ReportDataSource(name: "DataSet1", dataSourceValue: categories.Rows);

            Persistence.DatabaseContext databaseContext = new();

            var items = databaseContext.Categories
                .ToList()
                ;

            ReportDataSource reportDataSource =
                new ReportDataSource(name: "DataSet1", dataSourceValue: items);


            reportViewer.LocalReport.ReportPath =
                @"D:\MyFolder\MyLearning\C# - Courses\C#-Programming\Sources\LEARNING_EF_CORE_WITH_SQLITE\LEARNING_EF_CORE_WITH_SQLITE\Reports\CategoryReport.rdlc";

            reportViewer.LocalReport.DataSources.Add(reportDataSource);

            reportViewer.RefreshReport();

            this.Controls.Add(reportViewer);


        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    reportViewer.LocalReport.DataSources.Clear();

        //    //DataSet1TableAdapters.CategoriesTableAdapter categoriesTableAdapter =
        //    //    new DataSet1TableAdapters.CategoriesTableAdapter();

        //    //DataSet1.CategoriesDataTable categories =
        //    //    categoriesTableAdapter.GetData();

        //    //ReportDataSource reportDataSource =
        //    //    new ReportDataSource(name: "DataSet1", dataSourceValue: categories.Rows);

        //    Persistence.DatabaseContext databaseContext = new();
        //    var items = databaseContext.Categories
        //        .ToList()
        //        ;

        //    ReportDataSource reportDataSource =
        //        new ReportDataSource(name: "DataSet1", dataSourceValue: items);


        //    reportViewer.LocalReport.ReportPath =
        //        @"D:\MyFolder\MyLearning\C# - Courses\C#-Programming\Sources\LEARNING_EF_CORE_WITH_SQLITE\LEARNING_EF_CORE_WITH_SQLITE\Reports\CategoryReport.rdlc";

        //    reportViewer.LocalReport.DataSources.Add(reportDataSource);

        //    reportViewer.RefreshReport();

        //    this.Controls.Add(reportViewer);

        //    // reportViewer1.Show();


        //    //var report = new LocalReport();
        //    //Report.Load(report);
        //    //var pdf = report.Render("PDF");
        //    //File.WriteAllBytes("report.pdf", pdf);
        //}

        //public static void Load(LocalReport report)
        //{
        //    var items = new[] { new ReportItem { Description = "Widget 6000", Price = 104.99m, Qty = 1 }, new ReportItem { Description = "Gizmo MAX", Price = 1.41m, Qty = 25 } };
        //    var parameters = new[] { new ReportParameter("Title", "Invoice 4/2020") };
        //    using var fs = new FileStream("Report.rdlc", FileMode.Open);
        //    report.LoadReportDefinition(fs);
        //    report.DataSources.Add(new ReportDataSource("Items", items));
        //    report.SetParameters(parameters);
        //}
    }
}
