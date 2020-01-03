using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AssessorsUI
{
    public partial class frmPrintBlueGreen : Form
    {
        public frmPrintBlueGreen()
        {
            InitializeComponent();
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {

            this.reportViewer.RefreshReport();
        }
    }
}
