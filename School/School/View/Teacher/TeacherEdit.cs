using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School.Class;
using School.Interface;

namespace School.View.Teacher
{
    public partial class TeacherEdit : Form
    {
        public TeacherEdit()
        {
            InitializeComponent();
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            ClearInput.clearInput(this);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (
                this.txtFirstName.Text != "" &&
                this.txtLastName.Text != "" &&
                this.txtEmail.Text != "" &&
                this.txtProfession.Text != ""
                )
            {
                MessageBox.Show(TeacherClass.updateTeacher(this.idProfessor.Text, this.txtFirstName.Text, this.txtLastName.Text, this.txtEmail.Text, this.txtProfession.Text), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
