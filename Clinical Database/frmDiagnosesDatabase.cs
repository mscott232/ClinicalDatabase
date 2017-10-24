using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinical_Database
{
    public partial class frmDiagnosesDatabase : Form
    {
        public frmDiagnosesDatabase()
        {
            InitializeComponent();
        }

        private void diagnosesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.diagnosesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicalDBDataSet);

        }

        private void frmDiagnosesDatabase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicalDBDataSet.Diagnoses' table. You can move, or remove it, as needed.
            this.diagnosesTableAdapter.Fill(this.clinicalDBDataSet.Diagnoses);

        }
    }
}
