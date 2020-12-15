using AppQLSV.DAL;
using AppQLSV.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQLSV
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
            Loaddata();
        }

        private void Loaddata()
        {
            AppQLSVDBct db = new AppQLSVDBct();
            var ls = db.CLASSROOM.OrderBy(e => e.NAME).ToList();
           // var ls = db.CLASSROOM.ToList();
            blingsc.DataSource = ls;
            dataGridView1.DataSource = blingsc;
            //   var ls = db.STUDENT.ToList();
            //  dataGridView1.DataSource = ls;
            var temp = db.STUDENT.OrderBy(T => T.ID).ToList();
            blingsv.DataSource = temp;
            dataGridView2.DataSource = blingsv;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            var f = new Frmchitiet();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Loaddata();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            var lopdangchon = blingsc.Current as CLASSROOM;
            if (lopdangchon != null)
            {
                var rs = MessageBox.Show("Bạn có thực sự muốn xóa không ?", "chú ý",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
                );
                if (rs == DialogResult.OK)
                {
                    var db = new AppQLSVDBct();
                    var lop = db.CLASSROOM.Where(t => t.IDCLASS == lopdangchon.IDCLASS).FirstOrDefault();
                    if (lop != null)
                    {
                        db.CLASSROOM.Remove(lop);
                        db.SaveChanges();
                        Loaddata();
                    }
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            var lopdangchon = blingsc.Current as CLASSROOM;
            if (lopdangchon != null)
            {
                var f = new Frmchitiet(lopdangchon);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    Loaddata();
                }
            }
        }

        private void blingsc_CurrentChanged(object sender, EventArgs e)
        {
            var lopDangChon = blingsc.Current as CLASSROOM;
            if (lopDangChon != null)
            {
                var db = new AppQLSVDBct();
                var dsSV = db.STUDENT.Where(t => t.IDCLASS == lopDangChon.IDCLASS).ToList();
                blingsv.DataSource = dsSV;
                dataGridView2.DataSource = blingsv;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            var f = new Formsinhvien();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Loaddata();
            }
        }

        private void btnsuasv_Click(object sender, EventArgs e)
        {
            var sinhviendangchon = blingsv.Current as STUDENT;
            if (sinhviendangchon != null)
            {
                var f = new Formsinhvien(sinhviendangchon);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    Loaddata();
                }
            }
        }

        private void btnxoasv_Click(object sender, EventArgs e)
        {
            var sinhviendangchon = blingsv.Current as STUDENT;
            if (sinhviendangchon != null)
            {
                var rs = MessageBox.Show("Bạn có thực sự muốn xóa sinh viên này không không ?", "chú ý",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
                );
                if (rs == DialogResult.OK)
                {
                    var db = new AppQLSVDBct();
                    var sv = db.STUDENT.Where(t => t.ID == sinhviendangchon.ID).FirstOrDefault();
                    if (sv != null)
                    {
                        db.STUDENT.Remove(sv);
                        db.SaveChanges();
                        Loaddata();
                    }
                }
            }
        }
    }
}
