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
    public partial class frmFrame : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public frmFrame()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Tile open windows Vertically from the tool strip
        /// </summary>
        private void mnuWindowTile_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        /// <summary>
        /// Tile open windows horizontally from the tool strip
        /// </summary>
        private void mnuWindowLayer_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        /// <summary>
        /// Cascades all open windows from the tool strip
        /// </summary>
        private void mnuWindowCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        /// <summary>
        /// Close the form from the menu bar
        /// </summary>
        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        private void mnuFileOpenDiagnosesDatabase_Click(object sender, EventArgs e)
        {
            Form form = new frmDiagnosesDatabase();

            form.MdiParent = this;

            form.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        private void mnuFileOpenMedDatabase_Click(object sender, EventArgs e)
        {
            Form form = new frmMedDatabase();

            form.MdiParent = this;

            form.Show();
        }
    }
}
