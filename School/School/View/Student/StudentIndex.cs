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
        public StudentIndex()
        {
            InitializeComponent();
            this.OpenForms(new StudentDataTable());
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

        private void StudentHome_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'schoolDatabaseDataSet.Student'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.studentTableAdapter.Fill(this.schoolDatabaseDataSet.Student);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous avez recherché : " + this.txtSearch.Text + " dans la barre de recherche.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.OpenForms(new StudentEdit());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous avez cliqué sur 'Delete'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnStudentData_Click(object sender, EventArgs e)
        {
            this.OpenForms(new StudentDataTable());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.OpenForms(new StudentAdd());
        }
    }
}
