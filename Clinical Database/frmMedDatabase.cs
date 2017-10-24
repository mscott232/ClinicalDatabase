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
    public partial class frmMedDatabase : Form
    {
        public frmMedDatabase()
        {
            InitializeComponent();
        }

        private void medsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicalDBDataSet);

        }

        private void frmMedDatabase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicalDBDataSet.Meds' table. You can move, or remove it, as needed.
            this.medsTableAdapter.Fill(this.clinicalDBDataSet.Meds);

        }
    }
}
