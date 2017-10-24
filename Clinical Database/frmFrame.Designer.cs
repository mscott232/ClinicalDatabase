namespace Clinical_Database
{
    partial class frmFrame
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpenDiagnosesDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpenMedDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowTile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuWindow});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(282, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpen,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(44, 24);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpenDiagnosesDatabase,
            this.mnuFileOpenMedDatabase});
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(181, 26);
            this.mnuFileOpen.Text = "&Open";
            // 
            // mnuFileOpenDiagnosesDatabase
            // 
            this.mnuFileOpenDiagnosesDatabase.Name = "mnuFileOpenDiagnosesDatabase";
            this.mnuFileOpenDiagnosesDatabase.Size = new System.Drawing.Size(220, 26);
            this.mnuFileOpenDiagnosesDatabase.Text = "Diagnoses Database";
            this.mnuFileOpenDiagnosesDatabase.Click += new System.EventHandler(this.mnuFileOpenDiagnosesDatabase_Click);
            // 
            // mnuFileOpenMedDatabase
            // 
            this.mnuFileOpenMedDatabase.Name = "mnuFileOpenMedDatabase";
            this.mnuFileOpenMedDatabase.Size = new System.Drawing.Size(220, 26);
            this.mnuFileOpenMedDatabase.Text = "Med Database";
            this.mnuFileOpenMedDatabase.Click += new System.EventHandler(this.mnuFileOpenMedDatabase_Click);
            // 
            // mnuWindow
            // 
            this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuWindowTile,
            this.mnuWindowLayer,
            this.mnuWindowCascade});
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(76, 24);
            this.mnuWindow.Text = "&Window";
            // 
            // mnuWindowTile
            // 
            this.mnuWindowTile.Name = "mnuWindowTile";
            this.mnuWindowTile.Size = new System.Drawing.Size(181, 26);
            this.mnuWindowTile.Text = "&Tile";
            this.mnuWindowTile.Click += new System.EventHandler(this.mnuWindowTile_Click);
            // 
            // mnuWindowLayer
            // 
            this.mnuWindowLayer.Name = "mnuWindowLayer";
            this.mnuWindowLayer.Size = new System.Drawing.Size(181, 26);
            this.mnuWindowLayer.Text = "&Layer";
            this.mnuWindowLayer.Click += new System.EventHandler(this.mnuWindowLayer_Click);
            // 
            // mnuWindowCascade
            // 
            this.mnuWindowCascade.Name = "mnuWindowCascade";
            this.mnuWindowCascade.Size = new System.Drawing.Size(181, 26);
            this.mnuWindowCascade.Text = "&Cascade";
            this.mnuWindowCascade.Click += new System.EventHandler(this.mnuWindowCascade_Click);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(181, 26);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // frmFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmFrame";
            this.Text = "Clinical Database";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpenDiagnosesDatabase;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpenMedDatabase;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowTile;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowLayer;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
    }
}

