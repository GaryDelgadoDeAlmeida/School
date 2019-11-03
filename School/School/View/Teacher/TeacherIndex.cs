using School.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School.View.Teacher
{
    public partial class TeacherIndex : Form
    {
        private TeacherDataTable teacherData;
        public TeacherIndex()
        {
            InitializeComponent();
            this.teacherData = new TeacherDataTable();
            this.OpenForms(this.teacherData);
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

        private void btnTeacherData_Click(object sender, EventArgs e)
        {
            this.teacherData = new TeacherDataTable();
            this.OpenForms(this.teacherData);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TeacherEdit teacher = new TeacherEdit();

            if(this.teacherData.dataGridTeacher.SelectedRows.Count > 0)
            {
                // code
                teacher.idProfessor.Text = this.teacherData.dataGridTeacher.CurrentRow.Cells[0].Value.ToString();
                teacher.txtFirstName.Text = this.teacherData.dataGridTeacher.CurrentRow.Cells[1].Value.ToString();
                teacher.txtLastName.Text = this.teacherData.dataGridTeacher.CurrentRow.Cells[2].Value.ToString();
                teacher.txtEmail.Text = this.teacherData.dataGridTeacher.CurrentRow.Cells[3].Value.ToString();
                teacher.txtProfession.Text = this.teacherData.dataGridTeacher.CurrentRow.Cells[4].Value.ToString();
                this.OpenForms(teacher);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne pour l'éditer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (teacherData.dataGridTeacher.SelectedRows.Count > 0)
            {
                MessageBox.Show(TeacherClass.deleteStudent(this.teacherData.dataGridTeacher.CurrentRow.Cells[0].Value.ToString()));
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne pour l'étudiant", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.OpenForms(new TeacherAdd());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous avez recherché '" + this.txtSearch.Text + "' dans la barre de recherche.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
