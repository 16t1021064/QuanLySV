using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQLSV.DAL;

namespace AppQLSV.GUI
{
    public partial class Formsinhvien : Form
    {
        STUDENT sinhvien;
        public Formsinhvien()
        {
            InitializeComponent();
        }
        public Formsinhvien(STUDENT sinhvien)
        {
            InitializeComponent();
            this.Text = "chỉnh sửa sinh viên";
            this.sinhvien = sinhvien;
            txtmsv.Text = this.sinhvien.ID;
            txtfirstname.Text = this.sinhvien.FIRSTNAME;
            txtlastname.Text = this.sinhvien.LASTNAME;
            DOB.Value = this.sinhvien.DATEOFBIRTH.Value;
            txtPOB.Text = this.sinhvien.PLACEOFBIRTH;
           //gioi tinh
            txtidlop.Text = this.sinhvien.IDCLASS;
            //
            //
        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            addsv();
        }
        void addsv()
        {
            var masinhvien = txtmsv.Text;
            var ho = txtfirstname.Text;
            var ten = txtlastname.Text;
            var ngaysinh = DOB.Text;
            var noisinh = txtPOB.Text;
            int gt=0;
            if (rdbtnnam.Checked == true)
            {
                gt = 0;
            }
            else if (rdbtnnu.Checked == true)
            {
                gt = 1;
            }
            else if (rdbtnkhac.Checked == true)
            { gt = 2; }
            var idlop = txtidlop.Text;
            if(sinhvien==null)
            {
                STUDENT sv = new STUDENT
                {
                    ID = masinhvien,
                    FIRSTNAME = ho,
                    LASTNAME = ten,
                    DATEOFBIRTH = Convert.ToDateTime(ngaysinh),
                    PLACEOFBIRTH = noisinh,
                    GENDER=gt,
                    IDCLASS=idlop

                };
                AppQLSVDBct db =new AppQLSVDBct();
                db.STUDENT.Add(sv);
                db.SaveChanges();
    
                MessageBox.Show("Bạn đã thêm thành công sinh viên :)");
                DialogResult = DialogResult.OK;
            }else
            {
                var db = new AppQLSVDBct();
                var sv = db.STUDENT.Where(t => t.ID == sinhvien.ID).FirstOrDefault();
                sv.ID = masinhvien;
                sv.FIRSTNAME = ho;
                sv.LASTNAME = ten;
                sv.DATEOFBIRTH = Convert.ToDateTime(ngaysinh);
                sv.PLACEOFBIRTH = noisinh;
                sv.GENDER = gt;
                sv.IDCLASS = idlop;
                //db.STUDENT.Add(sinhvien);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }
        
    }
}
