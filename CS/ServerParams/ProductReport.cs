using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;

namespace ServerParams
{
    public partial class ProductReport : DevExpress.XtraReports.UI.XtraReport
    {
        public ProductReport()
        {
            InitializeComponent();
        }

        private void ProductReport_ParametersRequestSubmit(object sender, ParametersRequestEventArgs e)
        {
            if (Parameters["CategoryID"] != null)
                productsTableAdapter.FillByCategoryID(northwind1.Products, (int)Parameters["CategoryID"].Value);
        }

    }
}
