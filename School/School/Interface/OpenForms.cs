using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School.Interface
{
    static class OpenForms
    {
        public static void openForms(Form form, object formS)
        {
            if (form.pnlContainer.Controls.Count > 0)
            {
                form.pnlContainer.Controls.RemoveAt(0);
            }

            Form fs = formS as Form;
            fs.TopLevel = false;
            fs.Dock = DockStyle.Fill;
            form.pnlContainer.Controls.Add(fs);
            form.pnlContainer.Tag = fs;
            fs.Show();
        }
    }
}
