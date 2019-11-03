using School.Interface;
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

namespace School.View.Student
{
    public partial class StudentAdd : Form
    {
        public StudentAdd()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput.clearInput(this);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(
                this.txtFirstName.Text != "" &&
                this.txtLastName.Text != "" &&
                this.txtEmail.Text != "" &&
                this.txtClass.Text != ""
                )
            {
                MessageBox.Show(StudentClass.addStudent(this.txtFirstName.Text, this.txtLastName.Text, this.txtEmail.Text, this.txtClass.Text), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInput.clearInput(this);
            }
            else
            {
                MessageBox.Show("Veuillez vérifié que tous les champs sont bien remplis", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
