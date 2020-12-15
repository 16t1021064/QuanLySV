using AppQLSV.DAL;
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
    public partial class Frmchitiet : Form
    {
        CLASSROOM lophoc;
        public Frmchitiet()
        {
            //thêm mới
            InitializeComponent();
            this.Text = "thêm mới lớp học";
        }
        public Frmchitiet(CLASSROOM lophoc)
        {
            //chỉnh sửa
            InitializeComponent();
            this.Text = "chỉnh sửa lớp học";
            this.lophoc = lophoc;
            txtnameclass.Text = this.lophoc.NAME;
            txtclass.Text = this.lophoc.ROOM;
           // DialogResult = DialogResult.OK;

        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            addclassroom();
           // add();
        }
        void addclassroom() { 
            // thêm lớp
            var tenlop = txtnameclass.Text;
            var phonghoc = txtclass.Text;
            if (this.lophoc == null)
            {
                var lop = new CLASSROOM
                {
                    IDCLASS = Guid.NewGuid().ToString(),
                    NAME = tenlop,
                    ROOM = phonghoc

                };
                var db = new AppQLSVDBct();
                db.CLASSROOM.Add(lop);
                db.SaveChanges();
                //thêm lớp thành công trả về OK.
                MessageBox.Show("Bạn đã thêm lớp thành công :)");
                DialogResult = DialogResult.OK;
            }else
            {
                var db = new AppQLSVDBct();
                var lop = db.CLASSROOM.Where(t => t.IDCLASS == lophoc.IDCLASS).FirstOrDefault();
                lop.NAME = tenlop;
                lop.ROOM = phonghoc;
             //   db.CLASSROOM.Add(lophoc);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }
        void add()
        {
            var tenlop = txtnameclass.Text;
            var phonghoc = txtclass.Text;
            CLASSROOM lop = new CLASSROOM
            {
                IDCLASS = Guid.NewGuid().ToString(),
                NAME = tenlop,
                ROOM = phonghoc

            };
            var db = new AppQLSVDBct();
            var obj = db.CLASSROOM.Where(e => e.NAME == lop.NAME).FirstOrDefault();
            if(obj==null)
            {
                db.CLASSROOM.Add(lop);
                db.SaveChanges();
                MessageBox.Show("ban da them lop");
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("ko them duoc");
            }
        }
        }
    }
