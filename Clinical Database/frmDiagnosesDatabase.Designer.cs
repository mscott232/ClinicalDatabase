namespace Clinical_Database
{
    partial class frmDiagnosesDatabase
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
            this.cboDiagnosis = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbClinicalManifestations = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbTreatment = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbPatho = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rtbEffects = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rtbConsiderations = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rtbAssessments = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAbbreviation = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.clinicalDBDataSet = new Clinical_Database.ClinicalDBDataSet();
            this.diagnosesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosesTableAdapter = new Clinical_Database.ClinicalDBDataSetTableAdapters.DiagnosesTableAdapter();
            this.tableAdapterManager = new Clinical_Database.ClinicalDBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.clinicalDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDiagnosis
            // 
            this.cboDiagnosis.DataSource = this.diagnosesBindingSource;
            this.cboDiagnosis.DisplayMember = "Diagnosis";
            this.cboDiagnosis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiagnosis.FormattingEnabled = true;
            this.cboDiagnosis.Location = new System.Drawing.Point(177, 26);
            this.cboDiagnosis.Name = "cboDiagnosis";
            this.cboDiagnosis.Size = new System.Drawing.Size(308, 24);
            this.cboDiagnosis.TabIndex = 0;
            this.cboDiagnosis.ValueMember = "DiagnosisId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medical Diagnosis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clinical Manifestations:";
            // 
            // rtbClinicalManifestations
            // 
            this.rtbClinicalManifestations.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnosesBindingSource, "ClinicalManifestations", true));
            this.rtbClinicalManifestations.Location = new System.Drawing.Point(177, 239);
            this.rtbClinicalManifestations.Name = "rtbClinicalManifestations";
            this.rtbClinicalManifestations.ReadOnly = true;
            this.rtbClinicalManifestations.Size = new System.Drawing.Size(308, 133);
            this.rtbClinicalManifestations.TabIndex = 3;
            this.rtbClinicalManifestations.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Treatment/Plan/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Teaching/Meds:";
            // 
            // rtbTreatment
            // 
            this.rtbTreatment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnosesBindingSource, "Treatment", true));
            this.rtbTreatment.Location = new System.Drawing.Point(177, 392);
            this.rtbTreatment.Name = "rtbTreatment";
            this.rtbTreatment.ReadOnly = true;
            this.rtbTreatment.Size = new System.Drawing.Size(308, 127);
            this.rtbTreatment.TabIndex = 6;
            this.rtbTreatment.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pathophysiology:";
            // 
            // rtbPatho
            // 
            this.rtbPatho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnosesBindingSource, "Pathophysiology", true));
            this.rtbPatho.Location = new System.Drawing.Point(177, 74);
            this.rtbPatho.Name = "rtbPatho";
            this.rtbPatho.ReadOnly = true;
            this.rtbPatho.Size = new System.Drawing.Size(308, 142);
            this.rtbPatho.TabIndex = 8;
            this.rtbPatho.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Effect on Resident/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Potential Complications/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(548, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Is the Treatment";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(585, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Effective?:";
            // 
            // rtbEffects
            // 
            this.rtbEffects.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnosesBindingSource, "Effects", true));
            this.rtbEffects.Location = new System.Drawing.Point(665, 74);
            this.rtbEffects.Name = "rtbEffects";
            this.rtbEffects.ReadOnly = true;
            this.rtbEffects.Size = new System.Drawing.Size(291, 142);
            this.rtbEffects.TabIndex = 13;
            this.rtbEffects.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(559, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Gerontological";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(553, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Considerations:";
            // 
            // rtbConsiderations
            // 
            this.rtbConsiderations.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnosesBindingSource, "Considerations", true));
            this.rtbConsiderations.Location = new System.Drawing.Point(665, 239);
            this.rtbConsiderations.Name = "rtbConsiderations";
            this.rtbConsiderations.ReadOnly = true;
            this.rtbConsiderations.Size = new System.Drawing.Size(291, 133);
            this.rtbConsiderations.TabIndex = 16;
            this.rtbConsiderations.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(520, 395);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Priority Assessments";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(559, 412);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "and Rationale:";
            // 
            // rtbAssessments
            // 
            this.rtbAssessments.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnosesBindingSource, "Assessments", true));
            this.rtbAssessments.Location = new System.Drawing.Point(665, 392);
            this.rtbAssessments.Name = "rtbAssessments";
            this.rtbAssessments.ReadOnly = true;
            this.rtbAssessments.Size = new System.Drawing.Size(291, 127);
            this.rtbAssessments.TabIndex = 19;
            this.rtbAssessments.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(568, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Abbreviation:";
            // 
            // txtAbbreviation
            // 
            this.txtAbbreviation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnosesBindingSource, "Abbreviation", true));
            this.txtAbbreviation.Location = new System.Drawing.Point(665, 26);
            this.txtAbbreviation.Name = "txtAbbreviation";
            this.txtAbbreviation.ReadOnly = true;
            this.txtAbbreviation.Size = new System.Drawing.Size(291, 22);
            this.txtAbbreviation.TabIndex = 21;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(556, 540);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 23);
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(390, 540);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(142, 23);
            this.btnEdit.TabIndex = 49;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // clinicalDBDataSet
            // 
            this.clinicalDBDataSet.DataSetName = "ClinicalDBDataSet";
            this.clinicalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diagnosesBindingSource
            // 
            this.diagnosesBindingSource.DataMember = "Diagnoses";
            this.diagnosesBindingSource.DataSource = this.clinicalDBDataSet;
            // 
            // diagnosesTableAdapter
            // 
            this.diagnosesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DiagnosesTableAdapter = this.diagnosesTableAdapter;
            this.tableAdapterManager.MedsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Clinical_Database.ClinicalDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmDiagnosesDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 583);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtAbbreviation);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.rtbAssessments);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rtbConsiderations);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rtbEffects);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbPatho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbTreatment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbClinicalManifestations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDiagnosis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDiagnosesDatabase";
            this.Text = "Diagnoses Database";
            this.Load += new System.EventHandler(this.frmDiagnosesDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clinicalDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDiagnosis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbClinicalManifestations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbTreatment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbPatho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rtbEffects;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rtbConsiderations;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox rtbAssessments;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAbbreviation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private ClinicalDBDataSet clinicalDBDataSet;
        private System.Windows.Forms.BindingSource diagnosesBindingSource;
        private ClinicalDBDataSetTableAdapters.DiagnosesTableAdapter diagnosesTableAdapter;
        private ClinicalDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}