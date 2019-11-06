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

namespace School.View.Classroom
{
    public partial class ClassroomAdd : Form
    {
        public ClassroomAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // code
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (
                this.txtName.Text != ""
                )
            {
                MessageBox.Show(ClassroomClass.addClassroom(this.txtName.Text, this.txtPromotionDate.Value.ToString()), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
            }
        }
    }
}
