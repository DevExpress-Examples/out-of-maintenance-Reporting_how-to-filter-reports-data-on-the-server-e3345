using System;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
// ...

namespace ServerParams {
    public partial class Main : XtraForm {
        public Main() {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e) {
            ProductReport report = new ProductReport();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
    }
}
