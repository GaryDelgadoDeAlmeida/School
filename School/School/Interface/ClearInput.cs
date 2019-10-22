using School.View.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School.Interface
{
    static class ClearInput
    {
        public static void clearInput(StudentAdd formS)
        {
            formS.txtFirstName.Clear();
            formS.txtLastName.Clear();
            formS.txtEmail.Clear();
            formS.txtPhone.Clear();
            formS.txtAddress.Clear();
            formS.txtPostalCode.Clear();
            formS.txtCity.Clear();
            formS.txtCountry.Clear();
        }

        public static void clearInput(StudentEdit formS)
        {
            formS.txtFirstName.Clear();
            formS.txtLastName.Clear();
            formS.txtEmail.Clear();
            formS.txtPhone.Clear();
            formS.txtAddress.Clear();
            formS.txtPostalCode.Clear();
            formS.txtCity.Clear();
            formS.txtCountry.Clear();
        }
    }
}
