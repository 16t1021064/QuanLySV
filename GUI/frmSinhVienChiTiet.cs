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


namespace AppQLSV.GUI
{
    public partial class frmSinhVienChiTiet : Form
    {
        private Student sinhVien;
        public frmSinhVienChiTiet()
        {   
            InitializeComponent();
            this.Text = " thêm mới lớp học ";
        }
        public frmSinhVienChiTiet(Student sinhVien)
        {
            InitializeComponent();
            this.Text = "thêm sinh viên chi tiết";
            this.sinhVien = sinhVien;
            txtTenSV.Text = this.sinhVien.FirstName;
            txtHoSV.Text = this.sinhVien.LastName;
            txtNoiSinh.Text = this.sinhVien.PlaceOfBirth;
            dtpNgaySinh.Value = this.sinhVien.DateOfBirth.Value;
            txtMaSV.Text = this.sinhVien.ID;
            //if (this.sinhvien.gender = "0")
            //{
            //    rdbtnnam.checked = true;
            //    }
            //else if ({

            //    }
            }
        private void btnDongY_Click(object sender, EventArgs e)
        {
            var maSV = txtMaSV.Text;
            var ho = txtHoSV.Text;
            var ten = txtTenSV.Text;
            var ngaySinh = dtpNgaySinh.Value;
            var noiSinh = txtNoiSinh.Text;
            int gt = 0;
                if (rdBtnNam.Checked == true)
                {
                    gt = 0;
                }
                else if (rdBtnNu.Checked == true)
                {
                    gt = 1;
                }
                else if (rdBtnKhac.Checked == true)
                { 
                    gt = 2; 
                };
            var idLop = txtMaLop.Text;
            if (this.sinhVien == null)
            {
                var sv = new Student
                {
                    ID = idLop,
                    FirstName = ten,
                    LastName = ho,
                    Gender = gt,
                    DateOfBirth = ngaySinh,
                    PlaceOfBirth = noiSinh,
                    IDClassroom = idLop
                };
                var db = new AppQLSVDBContext();
                db.Students.Add(sv);
                db.SaveChanges();
                MessageBox.Show("Bạn đã thêm thành công sinh viên :)");
                DialogResult = DialogResult.OK;
            }
            else
            {
                var db = new AppQLSVDBContext();
                var sv = db.Students.Where(t => t.ID == sinhVien.ID).FirstOrDefault();
                sv.FirstName = ten;
                sv.LastName = ho;
                sv.Gender = gt;   
                sv.DateOfBirth = ngaySinh;
                sv.PlaceOfBirth = noiSinh;
                sv.IDClassroom = idLop;
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }   
    }
}
