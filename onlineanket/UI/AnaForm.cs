using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using onlineanket.BL;
using onlineanket.UI;

namespace onlineanket
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btnkayitekle_Click(object sender, EventArgs e)
        {
            FrmTeacher frmTeacher = new FrmTeacher()
            {
                Text = "Öğretmen ekle",
                Teachers = new teachers() { teacher_id = Guid.NewGuid() },
            };

        tekrar:
            var sonuc = frmTeacher.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.Ogretmenekle(frmTeacher.Teachers);
                if (b)
                {
                    DataSet ds = BLogic.Ogretmengetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];

                }
                else
                    goto tekrar;
            }

        }

        private void btnkayitbul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.Ogretmengetir(txtSearch.Text);
            if (ds != null)

                dataGridView1.DataSource = ds.Tables[0];
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.Ogretmengetir("");
            if (ds != null)

                dataGridView1.DataSource = ds.Tables[0];

            DataSet ds2 = BLogic.Ogrencigetir("");
            if (ds != null)

                dataGridView2.DataSource = ds.Tables[0];
        }

        private void btnogretmendüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];///datagridview2
            FrmTeacher frmTeacher = new FrmTeacher()
            {
                Text = "Öğretmen Güncelle",
                Guncelleme = true,
                Teachers = new teachers()
                {
                    teacher_id = Guid.Parse(row.Cells[0].Value.ToString()),
                    first_name = row.Cells[1].Value.ToString(),
                    last_name = row.Cells[2].Value.ToString(),
                    konusu = row.Cells[3].Value.ToString(),
                },
            };
            var sonuc = frmTeacher.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OgretmenGuncelle(frmTeacher.Teachers);
                if (b)
                {
                    row.Cells[1].Value = frmTeacher.Teachers.first_name;
                    row.Cells[2].Value = frmTeacher.Teachers.last_name;
                    row.Cells[3].Value = frmTeacher.Teachers.konusu;

                }
            }
        }

        private void btnogrencisil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var id = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Kaydı silmeyi onaylıyor musunuz?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OgretmenSil(id);
                if (b)
                {
                    DataSet ds = BLogic.Ogretmengetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];

                }
            }
        }
        
        }
    }
















//////frm teacher la studentı değiştri
///id kısımında hata veriyor.sebebini bul
///                   teacher_id = Guid.Parse(row.Cells[0].Value.ToString()),
//                    first_name=row.Cells[1].Value.ToString(),
//           last_name = row.Cells[2].Value.ToString(),
//          konusu = row.Cells[3].Value.ToString(),

// row.Cells[1].Value = frmTeacher.Teachers.first_name;