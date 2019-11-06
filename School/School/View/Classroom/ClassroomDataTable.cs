using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School.View.Classroom
{
    public partial class ClassroomDataTable : Form
    {
        public ClassroomDataTable()
        {
            InitializeComponent();
        }

        private void ClassDataTable_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'schoolDatabaseDataSet.Class'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.classTableAdapter.Fill(this.schoolDatabaseDataSet.Class);

        }
    }
}
