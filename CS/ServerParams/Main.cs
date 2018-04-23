using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ServerParams
{
    public partial class Main : XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            ProductReport report = new ProductReport();
            report.ShowPreviewDialog();
        }
    }
}
