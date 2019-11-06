namespace School.View.Classroom
{
    partial class ClassroomDataTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridClass = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promotionYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDatabaseDataSet = new School.SchoolDatabaseDataSet();
            this.classTableAdapter = new School.SchoolDatabaseDataSetTableAdapters.ClassTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridClass
            // 
            this.dataGridClass.AllowUserToAddRows = false;
            this.dataGridClass.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridClass.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridClass.AutoGenerateColumns = false;
            this.dataGridClass.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridClass.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.promotionYearDataGridViewTextBoxColumn});
            this.dataGridClass.DataSource = this.classBindingSource;
            this.dataGridClass.DoubleBuffered = true;
            this.dataGridClass.EnableHeadersVisualStyles = false;
            this.dataGridClass.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGridClass.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.dataGridClass.Location = new System.Drawing.Point(12, 12);
            this.dataGridClass.MultiSelect = false;
            this.dataGridClass.Name = "dataGridClass";
            this.dataGridClass.ReadOnly = true;
            this.dataGridClass.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridClass.RowHeadersWidth = 51;
            this.dataGridClass.RowTemplate.Height = 24;
            this.dataGridClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClass.Size = new System.Drawing.Size(1231, 566);
            this.dataGridClass.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // promotionYearDataGridViewTextBoxColumn
            // 
            this.promotionYearDataGridViewTextBoxColumn.DataPropertyName = "PromotionYear";
            this.promotionYearDataGridViewTextBoxColumn.HeaderText = "PromotionYear";
            this.promotionYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.promotionYearDataGridViewTextBoxColumn.Name = "promotionYearDataGridViewTextBoxColumn";
            this.promotionYearDataGridViewTextBoxColumn.ReadOnly = true;
            this.promotionYearDataGridViewTextBoxColumn.Width = 125;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.schoolDatabaseDataSet;
            // 
            // schoolDatabaseDataSet
            // 
            this.schoolDatabaseDataSet.DataSetName = "SchoolDatabaseDataSet";
            this.schoolDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // ClassroomDataTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 590);
            this.Controls.Add(this.dataGridClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassroomDataTable";
            this.Text = "ClassDataTable";
            this.Load += new System.EventHandler(this.ClassDataTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SchoolDatabaseDataSet schoolDatabaseDataSet;
        private System.Windows.Forms.BindingSource classBindingSource;
        private SchoolDatabaseDataSetTableAdapters.ClassTableAdapter classTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn promotionYearDataGridViewTextBoxColumn;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dataGridClass;
    }
}