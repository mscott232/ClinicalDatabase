namespace Clinical_Database
{
    partial class frmMedDatabase
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
            this.components = new System.ComponentModel.Container();
            this.rtbAssessments = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rtbEffects = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbTreatment = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbMOA = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDiagnosis = new System.Windows.Forms.ComboBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.rtbUse = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbConsiderations = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.clinicalDBDataSet = new Clinical_Database.ClinicalDBDataSet();
            this.medsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medsTableAdapter = new Clinical_Database.ClinicalDBDataSetTableAdapters.MedsTableAdapter();
            this.tableAdapterManager = new Clinical_Database.ClinicalDBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.clinicalDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbAssessments
            // 
            this.rtbAssessments.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medsBindingSource, "Assessments", true));
            this.rtbAssessments.Location = new System.Drawing.Point(655, 196);
            this.rtbAssessments.Name = "rtbAssessments";
            this.rtbAssessments.ReadOnly = true;
            this.rtbAssessments.Size = new System.Drawing.Size(299, 85);
            this.rtbAssessments.TabIndex = 36;
            this.rtbAssessments.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(545, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "(Pre and Post):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(505, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Nursing Assessments";
            // 
            // rtbEffects
            // 
            this.rtbEffects.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medsBindingSource, "SideEffects", true));
            this.rtbEffects.Location = new System.Drawing.Point(655, 68);
            this.rtbEffects.Name = "rtbEffects";
            this.rtbEffects.ReadOnly = true;
            this.rtbEffects.Size = new System.Drawing.Size(299, 102);
            this.rtbEffects.TabIndex = 33;
            this.rtbEffects.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Relevant Side Effects/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Classification:";
            // 
            // rtbTreatment
            // 
            this.rtbTreatment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medsBindingSource, "Pharmacokinetics", true));
            this.rtbTreatment.Location = new System.Drawing.Point(175, 295);
            this.rtbTreatment.Name = "rtbTreatment";
            this.rtbTreatment.ReadOnly = true;
            this.rtbTreatment.Size = new System.Drawing.Size(308, 85);
            this.rtbTreatment.TabIndex = 26;
            this.rtbTreatment.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Pharmacokinetics:";
            // 
            // rtbMOA
            // 
            this.rtbMOA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medsBindingSource, "MOA", true));
            this.rtbMOA.Location = new System.Drawing.Point(175, 196);
            this.rtbMOA.Name = "rtbMOA";
            this.rtbMOA.ReadOnly = true;
            this.rtbMOA.Size = new System.Drawing.Size(308, 85);
            this.rtbMOA.TabIndex = 23;
            this.rtbMOA.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mechanism of Action:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Medication:";
            // 
            // cboDiagnosis
            // 
            this.cboDiagnosis.DataSource = this.medsBindingSource;
            this.cboDiagnosis.DisplayMember = "Medication";
            this.cboDiagnosis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiagnosis.FormattingEnabled = true;
            this.cboDiagnosis.Location = new System.Drawing.Point(175, 23);
            this.cboDiagnosis.Name = "cboDiagnosis";
            this.cboDiagnosis.Size = new System.Drawing.Size(213, 24);
            this.cboDiagnosis.TabIndex = 20;
            this.cboDiagnosis.ValueMember = "MedId";
            // 
            // txtClass
            // 
            this.txtClass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medsBindingSource, "Classification", true));
            this.txtClass.Location = new System.Drawing.Point(175, 71);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(308, 22);
            this.txtClass.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(132, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 17);
            this.label14.TabIndex = 41;
            this.label14.Text = "Use:";
            // 
            // rtbUse
            // 
            this.rtbUse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medsBindingSource, "Use", true));
            this.rtbUse.Location = new System.Drawing.Point(175, 109);
            this.rtbUse.Name = "rtbUse";
            this.rtbUse.ReadOnly = true;
            this.rtbUse.Size = new System.Drawing.Size(308, 61);
            this.rtbUse.TabIndex = 42;
            this.rtbUse.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Risk Factors:";
            // 
            // rtbConsiderations
            // 
            this.rtbConsiderations.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medsBindingSource, "Considerations", true));
            this.rtbConsiderations.Location = new System.Drawing.Point(655, 295);
            this.rtbConsiderations.Name = "rtbConsiderations";
            this.rtbConsiderations.ReadOnly = true;
            this.rtbConsiderations.Size = new System.Drawing.Size(299, 133);
            this.rtbConsiderations.TabIndex = 46;
            this.rtbConsiderations.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(543, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "Considerations:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(549, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 44;
            this.label8.Text = "Gerontological";
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(175, 405);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(142, 23);
            this.btnEdit.TabIndex = 47;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(341, 405);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 23);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(558, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 49;
            this.label9.Text = "Brand Name:";
            // 
            // txtBrand
            // 
            this.txtBrand.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medsBindingSource, "Brand", true));
            this.txtBrand.Location = new System.Drawing.Point(655, 23);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.ReadOnly = true;
            this.txtBrand.Size = new System.Drawing.Size(299, 22);
            this.txtBrand.TabIndex = 50;
            // 
            // clinicalDBDataSet
            // 
            this.clinicalDBDataSet.DataSetName = "ClinicalDBDataSet";
            this.clinicalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medsBindingSource
            // 
            this.medsBindingSource.DataMember = "Meds";
            this.medsBindingSource.DataSource = this.clinicalDBDataSet;
            // 
            // medsTableAdapter
            // 
            this.medsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DiagnosesTableAdapter = null;
            this.tableAdapterManager.MedsTableAdapter = this.medsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Clinical_Database.ClinicalDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmMedDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 451);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.rtbConsiderations);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbUse);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.rtbAssessments);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rtbEffects);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbTreatment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbMOA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDiagnosis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMedDatabase";
            this.Text = "Med Database";
            this.Load += new System.EventHandler(this.frmMedDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clinicalDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbAssessments;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbEffects;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbTreatment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbMOA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDiagnosis;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox rtbUse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbConsiderations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBrand;
        private ClinicalDBDataSet clinicalDBDataSet;
        private System.Windows.Forms.BindingSource medsBindingSource;
        private ClinicalDBDataSetTableAdapters.MedsTableAdapter medsTableAdapter;
        private ClinicalDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}