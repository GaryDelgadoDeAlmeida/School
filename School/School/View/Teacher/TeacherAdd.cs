using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School.Interface;
using School.Class;

namespace School.View.Teacher
{
    public partial class TeacherAdd : Form
    {
        public TeacherAdd()
        {
            InitializeComponent();
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            ClearInput.clearInput(this);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(
                this.txtFirstName.Text != "" &&
                this.txtLastName.Text != "" &&
                this.txtEmail.Text != "" &&
                this.txtProfession.Text != ""
                )
            {
                MessageBox.Show(TeacherClass.addTeacher(this.txtFirstName.Text, this.txtLastName.Text, this.txtEmail.Text, this.txtProfession.Text), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInput.clearInput(this);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
