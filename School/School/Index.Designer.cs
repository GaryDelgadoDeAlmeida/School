namespace School
{
    partial class SchoolApp
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchoolApp));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlHead = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnStudent = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClass = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTeacher = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnNormalize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlHead.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormalize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.pnlHead.Controls.Add(this.btnMinimize);
            this.pnlHead.Controls.Add(this.btnNormalize);
            this.pnlHead.Controls.Add(this.btnMaximize);
            this.pnlHead.Controls.Add(this.btnClose);
            this.pnlHead.Controls.Add(this.bunifuCustomLabel1);
            this.pnlHead.Controls.Add(this.bunifuImageButton1);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(1505, 50);
            this.pnlHead.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(66, 7);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(187, 30);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "School - Bunifu UI";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlHead;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.pnlMenu.Controls.Add(this.bunifuImageButton2);
            this.pnlMenu.Controls.Add(this.btnStudent);
            this.pnlMenu.Controls.Add(this.btnClass);
            this.pnlMenu.Controls.Add(this.btnTeacher);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(250, 690);
            this.pnlMenu.TabIndex = 1;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(250, 50);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1255, 690);
            this.pnlContainer.TabIndex = 2;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bunifuImageButton2.Image = global::School.Properties.Resources.school;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(33, 31);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(175, 152);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 3;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // btnStudent
            // 
            this.btnStudent.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStudent.BorderRadius = 0;
            this.btnStudent.ButtonText = "Student";
            this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudent.DisabledColor = System.Drawing.Color.Gray;
            this.btnStudent.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStudent.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStudent.Iconimage")));
            this.btnStudent.Iconimage_right = null;
            this.btnStudent.Iconimage_right_Selected = null;
            this.btnStudent.Iconimage_Selected = null;
            this.btnStudent.IconMarginLeft = 0;
            this.btnStudent.IconMarginRight = 0;
            this.btnStudent.IconRightVisible = true;
            this.btnStudent.IconRightZoom = 0D;
            this.btnStudent.IconVisible = true;
            this.btnStudent.IconZoom = 90D;
            this.btnStudent.IsTab = false;
            this.btnStudent.Location = new System.Drawing.Point(0, 368);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnStudent.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnStudent.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStudent.selected = false;
            this.btnStudent.Size = new System.Drawing.Size(250, 59);
            this.btnStudent.TabIndex = 2;
            this.btnStudent.Text = "Student";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStudent.Textcolor = System.Drawing.Color.White;
            this.btnStudent.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnClass
            // 
            this.btnClass.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClass.BorderRadius = 0;
            this.btnClass.ButtonText = "Class";
            this.btnClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClass.DisabledColor = System.Drawing.Color.Gray;
            this.btnClass.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClass.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClass.Iconimage")));
            this.btnClass.Iconimage_right = null;
            this.btnClass.Iconimage_right_Selected = null;
            this.btnClass.Iconimage_Selected = null;
            this.btnClass.IconMarginLeft = 0;
            this.btnClass.IconMarginRight = 0;
            this.btnClass.IconRightVisible = true;
            this.btnClass.IconRightZoom = 0D;
            this.btnClass.IconVisible = true;
            this.btnClass.IconZoom = 90D;
            this.btnClass.IsTab = false;
            this.btnClass.Location = new System.Drawing.Point(0, 234);
            this.btnClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClass.Name = "btnClass";
            this.btnClass.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnClass.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnClass.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClass.selected = false;
            this.btnClass.Size = new System.Drawing.Size(250, 59);
            this.btnClass.TabIndex = 2;
            this.btnClass.Text = "Class";
            this.btnClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClass.Textcolor = System.Drawing.Color.White;
            this.btnClass.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTeacher.BorderRadius = 0;
            this.btnTeacher.ButtonText = "Teacher";
            this.btnTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeacher.DisabledColor = System.Drawing.Color.Gray;
            this.btnTeacher.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTeacher.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTeacher.Iconimage")));
            this.btnTeacher.Iconimage_right = null;
            this.btnTeacher.Iconimage_right_Selected = null;
            this.btnTeacher.Iconimage_Selected = null;
            this.btnTeacher.IconMarginLeft = 0;
            this.btnTeacher.IconMarginRight = 0;
            this.btnTeacher.IconRightVisible = true;
            this.btnTeacher.IconRightZoom = 0D;
            this.btnTeacher.IconVisible = true;
            this.btnTeacher.IconZoom = 90D;
            this.btnTeacher.IsTab = false;
            this.btnTeacher.Location = new System.Drawing.Point(0, 301);
            this.btnTeacher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnTeacher.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnTeacher.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTeacher.selected = false;
            this.btnTeacher.Size = new System.Drawing.Size(253, 59);
            this.btnTeacher.TabIndex = 1;
            this.btnTeacher.Text = "Teacher";
            this.btnTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTeacher.Textcolor = System.Drawing.Color.White;
            this.btnTeacher.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = global::School.Properties.Resources.minimizeWindow;
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(1391, 7);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnNormalize
            // 
            this.btnNormalize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNormalize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnNormalize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNormalize.Image = global::School.Properties.Resources.normalScreen;
            this.btnNormalize.ImageActive = null;
            this.btnNormalize.Location = new System.Drawing.Point(1427, 8);
            this.btnNormalize.Name = "btnNormalize";
            this.btnNormalize.Size = new System.Drawing.Size(30, 30);
            this.btnNormalize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNormalize.TabIndex = 2;
            this.btnNormalize.TabStop = false;
            this.btnNormalize.Visible = false;
            this.btnNormalize.Zoom = 10;
            this.btnNormalize.Click += new System.EventHandler(this.btnNormalize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Image = global::School.Properties.Resources.fullScreen;
            this.btnMaximize.ImageActive = null;
            this.btnMaximize.Location = new System.Drawing.Point(1427, 8);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Zoom = 10;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::School.Properties.Resources.deleteSign;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1463, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = global::School.Properties.Resources.menuFilled;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 8);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // SchoolApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 740);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SchoolApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School";
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormalize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlHead;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMaximize;
        private Bunifu.Framework.UI.BunifuImageButton btnNormalize;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private System.Windows.Forms.Panel pnlMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnTeacher;
        private Bunifu.Framework.UI.BunifuFlatButton btnStudent;
        private Bunifu.Framework.UI.BunifuFlatButton btnClass;
        private System.Windows.Forms.Panel pnlContainer;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
    }
}

