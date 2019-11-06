using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School.View.Student;
using School.View.Teacher;
using School.View.Classroom;
using School.View;

namespace School
{
    public partial class SchoolApp : Form
    {
        private Home home;
        public SchoolApp()
        {
            InitializeComponent();
            this.home = new Home();
            this.OpenForms(this.home);
        }

        private void OpenForms(object formS)
        {
            if(this.pnlContainer.Controls.Count > 0)
            {
                this.pnlContainer.Controls.RemoveAt(0);
            }

            Form fs = formS as Form;
            fs.TopLevel = false;
            fs.Dock = DockStyle.Fill;
            this.pnlContainer.Controls.Add(fs);
            this.pnlContainer.Tag = fs;
            fs.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.btnNormalize.Visible = true;
            this.btnMaximize.Visible = false;
        }

        private void btnNormalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.btnNormalize.Visible = false;
            this.btnMaximize.Visible = true;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            int y = this.picLogo.Location.Y;

            if (this.pnlMenu.Size.Width == 188)
            {
                // Menu
                this.pnlMenu.Size = new Size(50, this.pnlMenu.Size.Height);

                // Pic Logo
                this.picLogo.Location = new Point(10, this.picLogo.Location.Y);
                this.picLogo.Size = new Size(30, this.picLogo.Size.Height);
            }
            else
            {
                // Menu
                this.pnlMenu.Size = new Size(188, this.pnlMenu.Size.Height);

                // Pic Logo
                this.picLogo.Location = new Point(5, y);
                this.picLogo.Size = new Size(175, this.picLogo.Size.Height);
                this.picLogo.Zoom = 10;
            }
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.OpenForms(new StudentIndex());
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            this.OpenForms(new TeacherIndex());
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            this.OpenForms(new ClassroomIndex());
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.OpenForms(this.home);
        }
    }
}
