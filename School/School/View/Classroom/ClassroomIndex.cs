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
    public partial class ClassroomIndex : Form
    {
        private ClassroomDataTable classData;
        public ClassroomIndex()
        {
            InitializeComponent();
            this.classData = new ClassroomDataTable();
            this.OpenForms(classData);
        }

        private void OpenForms(object formS)
        {
            if (this.pnlContainer.Controls.Count > 0)
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

        private void btnList_Click(object sender, EventArgs e)
        {
            this.classData = new ClassroomDataTable();
            this.OpenForms(this.classData);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.OpenForms(new ClassroomAdd());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ClassroomEdit classEdit = new ClassroomEdit();
            DateTime convertedDate = new DateTime();

            try
            {
                convertedDate = Convert.ToDateTime(classData.dataGridClass.CurrentRow.Cells[2].Value.ToString());
                Console.WriteLine("'{0}' converts to {1} {2} time.",
                                  classData.dataGridClass.CurrentRow.Cells[2].Value.ToString(), convertedDate,
                                  convertedDate.Kind.ToString());
            }
            catch (FormatException)
            {
                Console.WriteLine("'{0}' is not in the proper format.", classData.dataGridClass.CurrentRow.Cells[2].Value.ToString());
            }

            if (this.classData.dataGridClass.SelectedRows.Count > 0)
            {
                classEdit.idClassroom.Text = this.classData.dataGridClass.CurrentRow.Cells[0].Value.ToString();
                classEdit.txtName.Text = this.classData.dataGridClass.CurrentRow.Cells[1].Value.ToString();
                classEdit.txtPromotionDate.Value = convertedDate;
                this.OpenForms(classEdit);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne pour l'éditer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (this.classData.dataGridClass.SelectedRows.Count > 0)
            {
                MessageBox.Show(ClassroomClass.deleteClassroom(this.classData.dataGridClass.CurrentRow.Cells[0].Value.ToString()), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne pour l'éditer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ConvertToDateTime(string value)
        {
            DateTime convertedDate;
            try
            {
                convertedDate = Convert.ToDateTime(value);
                Console.WriteLine("'{0}' converts to {1} {2} time.",
                                  value, convertedDate,
                                  convertedDate.Kind.ToString());
            }
            catch (FormatException)
            {
                Console.WriteLine("'{0}' is not in the proper format.", value);
            }
        }
    }
}
