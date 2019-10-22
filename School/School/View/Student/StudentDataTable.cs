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
    public partial class StudentDataTable : Form
    {
        public StudentDataTable()
        {
            InitializeComponent();
        }

        private void StudentDataTable_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'schoolDatabaseDataSet.Student'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.studentTableAdapter.Fill(this.schoolDatabaseDataSet.Student);

        }
    }
}
