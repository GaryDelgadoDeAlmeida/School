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
    public partial class TeacherDataTable : Form
    {
        public TeacherDataTable()
        {
            InitializeComponent();
        }

        private void TeacherDataTable_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'schoolDatabaseDataSet.Teacher'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.teacherTableAdapter.Fill(this.schoolDatabaseDataSet.Teacher);

        }
    }
}
