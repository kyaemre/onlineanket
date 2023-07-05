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
    public partial class FrmTeacher : Form
    {
        public FrmTeacher()
        {
            InitializeComponent();
        }

       public teachers Teachers { get; set; }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public teachers teachers { get; set; }
        public bool Guncelleme { get; set; } = false; 
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtfirstname)) return;
            if (!ErrorControl(txtlastname)) return;
            if (!ErrorControl(txtsubject)) return;

            Teachers.first_name = txtfirstname.Text;
            Teachers.last_name = txtlastname.Text;
            Teachers.konusu = txtsubject.Text;
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
        private void FrmTeacher_Load(object sender, EventArgs e)
        {
            txtıd.Text = Teachers.teacher_id.ToString();
            if(Guncelleme)
            {
                txtfirstname.Text=Teachers.first_name  ;
                txtlastname.Text = Teachers.last_name;
                txtsubject.Text = Teachers.konusu;
                

            }
        }

        private void txtıd_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

  
