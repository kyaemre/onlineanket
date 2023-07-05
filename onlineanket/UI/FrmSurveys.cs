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
    public partial class FrmSurveys : Form
    {
        public FrmSurveys()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtstudentıd)) return;
            if (!ErrorControl(txtcourseıd)) return;
            if (!ErrorControl(txtfeedback)) return;
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
