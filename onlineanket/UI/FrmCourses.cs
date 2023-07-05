using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onlineanket.UI
{
    public partial class FrmCourses : Form
    {
        public FrmCourses()
        {
            InitializeComponent();
        }

        private void FrmCourses_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtname)) return;
            if (!ErrorControl(txtteacherıd)) return;
            if (!ErrorControl(txtsurveyıd)) return;
            DialogResult = DialogResult.OK;
        }
        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;

                }

            }
            return true;
        }
    }
}
