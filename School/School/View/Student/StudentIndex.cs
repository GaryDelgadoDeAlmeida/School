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

namespace School.View.Student
{
    public partial class StudentIndex : Form
    {
        private StudentDataTable studentData;
        public StudentIndex()
        {
            InitializeComponent();
            this.studentData = new StudentDataTable();
            this.OpenForms(this.studentData);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous avez recherché : " + this.txtSearch.Text + " dans la barre de recherche.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            StudentEdit studentEdit = new StudentEdit();

            if(studentData.dataGridStudent.SelectedRows.Count > 0)
            {
                studentEdit.txtIdentifiant.Text = this.studentData.dataGridStudent.CurrentRow.Cells[0].Value.ToString();
                studentEdit.txtFirstName.Text = this.studentData.dataGridStudent.CurrentRow.Cells[1].Value.ToString();
                studentEdit.txtLastName.Text = this.studentData.dataGridStudent.CurrentRow.Cells[2].Value.ToString();
                studentEdit.txtEmail.Text = this.studentData.dataGridStudent.CurrentRow.Cells[3].Value.ToString();
                studentEdit.txtClass.Text = this.studentData.dataGridStudent.CurrentRow.Cells[4].Value.ToString();
                this.OpenForms(studentEdit);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne pour l'éditer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (studentData.dataGridStudent.SelectedRows.Count > 0)
            {
                MessageBox.Show(StudentClass.deleteStudent(this.studentData.dataGridStudent.CurrentRow.Cells[0].Value.ToString()));
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne pour l'étudiant", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStudentData_Click(object sender, EventArgs e)
        {
            this.studentData = new StudentDataTable();
            this.OpenForms(this.studentData);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.OpenForms(new StudentAdd());
        }
    }
}
