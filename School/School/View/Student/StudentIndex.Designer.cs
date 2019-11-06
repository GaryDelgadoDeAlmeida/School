namespace School.View.Student
{
    partial class StudentIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentIndex));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.schoolDatabaseDataSet = new School.SchoolDatabaseDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new School.SchoolDatabaseDataSetTableAdapters.StudentTableAdapter();
            this.pnlHeadMenu = new System.Windows.Forms.Panel();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlStudentData = new System.Windows.Forms.Panel();
            this.btnSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnStudentData = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnlDelete = new System.Windows.Forms.Panel();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.pnlHeadMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // schoolDatabaseDataSet
            // 
            this.schoolDatabaseDataSet.DataSetName = "SchoolDatabaseDataSet";
            this.schoolDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.schoolDatabaseDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // pnlHeadMenu
            // 
            this.pnlHeadMenu.Controls.Add(this.pnlAdd);
            this.pnlHeadMenu.Controls.Add(this.btnAdd);
            this.pnlHeadMenu.Controls.Add(this.pnlStudentData);
            this.pnlHeadMenu.Controls.Add(this.btnSearch);
            this.pnlHeadMenu.Controls.Add(this.btnStudentData);
            this.pnlHeadMenu.Controls.Add(this.txtSearch);
            this.pnlHeadMenu.Controls.Add(this.pnlDelete);
            this.pnlHeadMenu.Controls.Add(this.btnDelete);
            this.pnlHeadMenu.Controls.Add(this.pnlEdit);
            this.pnlHeadMenu.Controls.Add(this.btnEdit);
            this.pnlHeadMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeadMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlHeadMenu.Name = "pnlHeadMenu";
            this.pnlHeadMenu.Size = new System.Drawing.Size(1255, 100);
            this.pnlHeadMenu.TabIndex = 0;
            // 
            // pnlAdd
            // 
            this.pnlAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.pnlAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlAdd.Location = new System.Drawing.Point(872, 62);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(136, 5);
            this.pnlAdd.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.Empty;
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.ButtonText = "New Student";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = null;
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = true;
            this.btnAdd.IconZoom = 90D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(872, 18);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.Empty;
            this.btnAdd.OnHovercolor = System.Drawing.Color.Empty;
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(136, 50);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "New Student";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Textcolor = System.Drawing.Color.Gray;
            this.btnAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlStudentData
            // 
            this.pnlStudentData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlStudentData.BackColor = System.Drawing.Color.Black;
            this.pnlStudentData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlStudentData.Location = new System.Drawing.Point(394, 63);
            this.pnlStudentData.Name = "pnlStudentData";
            this.pnlStudentData.Size = new System.Drawing.Size(136, 5);
            this.pnlStudentData.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Image = global::School.Properties.Resources.search;
            this.btnSearch.ImageActive = null;
            this.btnSearch.Location = new System.Drawing.Point(21, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(45, 44);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch.TabIndex = 1;
            this.btnSearch.TabStop = false;
            this.btnSearch.Zoom = 10;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnStudentData
            // 
            this.btnStudentData.Activecolor = System.Drawing.Color.Empty;
            this.btnStudentData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStudentData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStudentData.BorderRadius = 0;
            this.btnStudentData.ButtonText = "List";
            this.btnStudentData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentData.DisabledColor = System.Drawing.Color.Gray;
            this.btnStudentData.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStudentData.Iconimage = null;
            this.btnStudentData.Iconimage_right = null;
            this.btnStudentData.Iconimage_right_Selected = null;
            this.btnStudentData.Iconimage_Selected = null;
            this.btnStudentData.IconMarginLeft = 0;
            this.btnStudentData.IconMarginRight = 0;
            this.btnStudentData.IconRightVisible = true;
            this.btnStudentData.IconRightZoom = 0D;
            this.btnStudentData.IconVisible = true;
            this.btnStudentData.IconZoom = 90D;
            this.btnStudentData.IsTab = false;
            this.btnStudentData.Location = new System.Drawing.Point(394, 19);
            this.btnStudentData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStudentData.Name = "btnStudentData";
            this.btnStudentData.Normalcolor = System.Drawing.Color.Empty;
            this.btnStudentData.OnHovercolor = System.Drawing.Color.Empty;
            this.btnStudentData.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnStudentData.selected = false;
            this.btnStudentData.Size = new System.Drawing.Size(136, 50);
            this.btnStudentData.TabIndex = 4;
            this.btnStudentData.Text = "List";
            this.btnStudentData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStudentData.Textcolor = System.Drawing.Color.Gray;
            this.btnStudentData.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentData.Click += new System.EventHandler(this.btnStudentData_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearch.HintText = "";
            this.txtSearch.isPassword = false;
            this.txtSearch.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSearch.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSearch.LineThickness = 3;
            this.txtSearch.Location = new System.Drawing.Point(82, 25);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(218, 44);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.Text = "Search";
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pnlDelete
            // 
            this.pnlDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlDelete.Location = new System.Drawing.Point(711, 62);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(136, 5);
            this.pnlDelete.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.Empty;
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = null;
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 90D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(711, 18);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.Empty;
            this.btnDelete.OnHovercolor = System.Drawing.Color.Empty;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(136, 50);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.Gray;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.pnlEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlEdit.Location = new System.Drawing.Point(551, 62);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(136, 5);
            this.pnlEdit.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Activecolor = System.Drawing.Color.Empty;
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.BorderRadius = 0;
            this.btnEdit.ButtonText = "Edit";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DisabledColor = System.Drawing.Color.Gray;
            this.btnEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEdit.Iconimage = null;
            this.btnEdit.Iconimage_right = null;
            this.btnEdit.Iconimage_right_Selected = null;
            this.btnEdit.Iconimage_Selected = null;
            this.btnEdit.IconMarginLeft = 0;
            this.btnEdit.IconMarginRight = 0;
            this.btnEdit.IconRightVisible = true;
            this.btnEdit.IconRightZoom = 0D;
            this.btnEdit.IconVisible = true;
            this.btnEdit.IconZoom = 90D;
            this.btnEdit.IsTab = false;
            this.btnEdit.Location = new System.Drawing.Point(551, 18);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.Empty;
            this.btnEdit.OnHovercolor = System.Drawing.Color.Empty;
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(136, 50);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Textcolor = System.Drawing.Color.Gray;
            this.btnEdit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 100);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1255, 590);
            this.pnlContainer.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuImageButton1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 31);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(45, 44);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // StudentIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1255, 690);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlHeadMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentIndex";
            this.Text = "StudentHome";
            ((System.ComponentModel.ISupportInitialize)(this.schoolDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.pnlHeadMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private SchoolDatabaseDataSet schoolDatabaseDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private SchoolDatabaseDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Panel pnlHeadMenu;
        private System.Windows.Forms.Panel pnlContainer;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Panel pnlDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        private Bunifu.Framework.UI.BunifuImageButton btnSearch;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel pnlStudentData;
        private Bunifu.Framework.UI.BunifuFlatButton btnStudentData;
        private System.Windows.Forms.Panel pnlAdd;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
    }
}