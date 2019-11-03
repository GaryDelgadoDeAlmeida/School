using School.View.Student;
using School.View.Teacher;
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
            formS.txtClass.Clear();
        }

        public static void clearInput(StudentEdit formS)
        {
            formS.txtFirstName.Clear();
            formS.txtLastName.Clear();
            formS.txtEmail.Clear();
            formS.txtClass.Clear();
        }

        public static void clearInput(TeacherAdd formS)
        {
            formS.txtFirstName.Clear();
            formS.txtLastName.Clear();
            formS.txtEmail.Clear();
            formS.txtProfession.Clear();
        }

        public static void clearInput(TeacherEdit formS)
        {
            formS.txtFirstName.Clear();
            formS.txtLastName.Clear();
            formS.txtEmail.Clear();
            formS.txtProfession.Clear();
        }
    }
}
