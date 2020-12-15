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
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
            gridLopHoc.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
            LoadDanhSachLopHoc();
        }
        private void LoadDanhSachLopHoc()
        {
            var db = new AppQLSVDBContext();
            var ls = db.Classrooms.OrderBy(e => e.Name).ToList();
            // var ls = db.CLASSROOM.ToList();
            bdsLopHoc.DataSource = ls;
            gridLopHoc.DataSource = bdsLopHoc;
            //   var ls = db.STUDENT.ToList();
            //  dataGridView1.DataSource = ls;
            var temp = db.Students.OrderBy(T => T.ID).ToList();
            bdsSinhVien.DataSource = temp;
            dataGridView2.DataSource = bdsSinhVien;
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            var f = new frmLopChiTiet();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachLopHoc();
            }
        }
        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            var f = new frmSinhVienChiTiet();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachLopHoc();
            }
        }
       
        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            var lopDangChon = bdsLopHoc.Current as Classroom;
            if (lopDangChon != null)
            {
                var rs = MessageBox.Show(
                    "Bạn có thực sự muốn xóa không?",
                    "Chú ý",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    //Xóa lớp đang chọn
                    AppQLSVDBContext db = new AppQLSVDBContext();
                    var lop = db.Classrooms.Where(t => t.ID == lopDangChon.ID).FirstOrDefault();
                    if (lop != null)
                    {
                        db.Classrooms.Remove(lop);
                        db.SaveChanges();
                        LoadDanhSachLopHoc();
                    }
                }

            }
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            var lopDangChon = bdsLopHoc.Current as Classroom;
            if (lopDangChon != null)
            {
                var f = new frmLopChiTiet(lopDangChon);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadDanhSachLopHoc();
                }
            }
        }

        private void bdsLopHoc_CurrentChanged(object sender, EventArgs e)
        {
            var lopDangChon = bdsLopHoc.Current as Classroom;
            if (lopDangChon != null)
            {
                var db = new AppQLSVDBContext();
                var dsSV = db.Students.Where(t => t.IDClassroom == lopDangChon.ID).ToList();
                bdsSinhVien.DataSource = dsSV;
                dataGridView2.DataSource = bdsSinhVien;
            }
        }
        
        private void bdsSinhVien_CurrentChanged(object sender, EventArgs e)
        {
            var sinhVienDangChon = bdsSinhVien.Current as Student;
            if (sinhVienDangChon != null)
            {
                var db = new AppQLSVDBContext();
                var dsLop = db.Classrooms.Where(t => t.ID == sinhVienDangChon.ID).ToList();
                bdsLopHoc.DataSource = dsLop;
                gridLopHoc.DataSource = bdsLopHoc;
            }
        }

        private void btnSuaSinhVien_Click(object sender, EventArgs e)
        {
            var sinhviendangchon = bdsSinhVien.Current as Student;
            if (sinhviendangchon != null)
            {
                var f = new frmSinhVienChiTiet(sinhviendangchon);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadDanhSachLopHoc();
                }
            }
        }

        private void btnXoaSinhVien_Click(object sender, EventArgs e)
        {
            var sinhVienDangChon = bdsSinhVien.Current as Classroom;
            if (sinhVienDangChon != null)
            {
                var rs = MessageBox.Show(
                    "Bạn có thực sự muốn xóa không?",
                    "Chú ý",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    //Xóa lớp đang chọn
                    AppQLSVDBContext db = new AppQLSVDBContext();
                    var sv = db.Students.Where(t => t.ID == sinhVienDangChon.ID).FirstOrDefault();
                    if (sv != null)
                    {
                        db.Students.Remove(sv);
                        db.SaveChanges();
                        LoadDanhSachLopHoc();
                    }
                }

            }
        }
    }
}
