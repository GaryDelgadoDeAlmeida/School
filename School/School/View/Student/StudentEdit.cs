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

namespace School.View.Student
{
    public partial class StudentEdit : Form
    {
        public StudentEdit()
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
                MessageBox.Show("Ca fonctionne", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInput.clearInput(this);
            }
            else
            {
                MessageBox.Show("Les champs ne peuvent être vide", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }
    }
}
