namespace Trying_to_do_a_database
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mUSICDataSet = new Trying_to_do_a_database.MUSICDataSet();
            this.ownerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ownerTableAdapter = new Trying_to_do_a_database.MUSICDataSetTableAdapters.OwnerTableAdapter();
            this.ownerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discJockeyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mUSICDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ownerIDDataGridViewTextBoxColumn,
            this.ownerSurnameDataGridViewTextBoxColumn,
            this.ownerFirstNameDataGridViewTextBoxColumn,
            this.contactDetailsDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.discJockeyDataGridViewCheckBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ownerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(960, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // mUSICDataSet
            // 
            this.mUSICDataSet.DataSetName = "MUSICDataSet";
            this.mUSICDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ownerBindingSource
            // 
            this.ownerBindingSource.DataMember = "Owner";
            this.ownerBindingSource.DataSource = this.mUSICDataSet;
            // 
            // ownerTableAdapter
            // 
            this.ownerTableAdapter.ClearBeforeFill = true;
            // 
            // ownerIDDataGridViewTextBoxColumn
            // 
            this.ownerIDDataGridViewTextBoxColumn.DataPropertyName = "OwnerID";
            this.ownerIDDataGridViewTextBoxColumn.HeaderText = "OwnerID";
            this.ownerIDDataGridViewTextBoxColumn.Name = "ownerIDDataGridViewTextBoxColumn";
            // 
            // ownerSurnameDataGridViewTextBoxColumn
            // 
            this.ownerSurnameDataGridViewTextBoxColumn.DataPropertyName = "OwnerSurname";
            this.ownerSurnameDataGridViewTextBoxColumn.HeaderText = "OwnerSurname";
            this.ownerSurnameDataGridViewTextBoxColumn.Name = "ownerSurnameDataGridViewTextBoxColumn";
            // 
            // ownerFirstNameDataGridViewTextBoxColumn
            // 
            this.ownerFirstNameDataGridViewTextBoxColumn.DataPropertyName = "OwnerFirstName";
            this.ownerFirstNameDataGridViewTextBoxColumn.HeaderText = "OwnerFirstName";
            this.ownerFirstNameDataGridViewTextBoxColumn.Name = "ownerFirstNameDataGridViewTextBoxColumn";
            // 
            // contactDetailsDataGridViewTextBoxColumn
            // 
            this.contactDetailsDataGridViewTextBoxColumn.DataPropertyName = "ContactDetails";
            this.contactDetailsDataGridViewTextBoxColumn.HeaderText = "ContactDetails";
            this.contactDetailsDataGridViewTextBoxColumn.Name = "contactDetailsDataGridViewTextBoxColumn";
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // discJockeyDataGridViewCheckBoxColumn
            // 
            this.discJockeyDataGridViewCheckBoxColumn.DataPropertyName = "DiscJockey";
            this.discJockeyDataGridViewCheckBoxColumn.HeaderText = "DiscJockey";
            this.discJockeyDataGridViewCheckBoxColumn.Name = "discJockeyDataGridViewCheckBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mUSICDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MUSICDataSet mUSICDataSet;
        private System.Windows.Forms.BindingSource ownerBindingSource;
        private MUSICDataSetTableAdapters.OwnerTableAdapter ownerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn discJockeyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
    }
}

