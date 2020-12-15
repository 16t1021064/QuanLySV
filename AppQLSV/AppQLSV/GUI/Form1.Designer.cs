namespace AppQLSV
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NAMECLASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnthem = new System.Windows.Forms.ToolStripButton();
            this.btnsua = new System.Windows.Forms.ToolStripButton();
            this.btndelete = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIRSTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LASTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCLASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.btnsuasv = new System.Windows.Forms.ToolStripButton();
            this.btnxoasv = new System.Windows.Forms.ToolStripButton();
            this.blingsc = new System.Windows.Forms.BindingSource(this.components);
            this.blingsv = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blingsc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blingsv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 374);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NAMECLASS,
            this.CLASS});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(283, 349);
            this.dataGridView1.TabIndex = 0;
            // 
            // NAMECLASS
            // 
            this.NAMECLASS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NAMECLASS.DataPropertyName = "NAME";
            this.NAMECLASS.HeaderText = "Tên lớp";
            this.NAMECLASS.Name = "NAMECLASS";
            // 
            // CLASS
            // 
            this.CLASS.DataPropertyName = "ROOM";
            this.CLASS.HeaderText = "Phòng học";
            this.CLASS.Name = "CLASS";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnthem,
            this.btnsua,
            this.btndelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(283, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // btnthem
            // 
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(58, 22);
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(46, 22);
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btndelete
            // 
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(47, 22);
            this.btndelete.Text = "Xóa";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(283, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 374);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FIRSTNAME,
            this.LASTNAME,
            this.DOB,
            this.POB,
            this.GT,
            this.IDCLASS});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(705, 349);
            this.dataGridView2.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã sinh viên";
            this.ID.Name = "ID";
            // 
            // FIRSTNAME
            // 
            this.FIRSTNAME.DataPropertyName = "FIRSTNAME";
            this.FIRSTNAME.HeaderText = "Họ";
            this.FIRSTNAME.Name = "FIRSTNAME";
            // 
            // LASTNAME
            // 
            this.LASTNAME.DataPropertyName = "LASTNAME";
            this.LASTNAME.HeaderText = "Tên";
            this.LASTNAME.Name = "LASTNAME";
            // 
            // DOB
            // 
            this.DOB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DOB.DataPropertyName = "DATEOFBIRTH";
            this.DOB.HeaderText = "Ngày sinh";
            this.DOB.Name = "DOB";
            // 
            // POB
            // 
            this.POB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.POB.DataPropertyName = "PLACEOFBIRTH";
            this.POB.HeaderText = "Nơi sinh";
            this.POB.Name = "POB";
            // 
            // GT
            // 
            this.GT.DataPropertyName = "GENDER";
            this.GT.HeaderText = "Giới tính";
            this.GT.Name = "GT";
            // 
            // IDCLASS
            // 
            this.IDCLASS.DataPropertyName = "IDCLASS";
            this.IDCLASS.HeaderText = "ID Lớp";
            this.IDCLASS.Name = "IDCLASS";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripButton4,
            this.btnsuasv,
            this.btnxoasv});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(705, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(112, 22);
            this.toolStripLabel2.Text = "Danh sách sinh viên";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(58, 22);
            this.toolStripButton4.Text = "Thêm";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // btnsuasv
            // 
            this.btnsuasv.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnsuasv.Image = ((System.Drawing.Image)(resources.GetObject("btnsuasv.Image")));
            this.btnsuasv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsuasv.Name = "btnsuasv";
            this.btnsuasv.Size = new System.Drawing.Size(46, 22);
            this.btnsuasv.Text = "Sửa";
            this.btnsuasv.Click += new System.EventHandler(this.btnsuasv_Click);
            // 
            // btnxoasv
            // 
            this.btnxoasv.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnxoasv.Image = ((System.Drawing.Image)(resources.GetObject("btnxoasv.Image")));
            this.btnxoasv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnxoasv.Name = "btnxoasv";
            this.btnxoasv.Size = new System.Drawing.Size(47, 22);
            this.btnxoasv.Text = "Xóa";
            this.btnxoasv.Click += new System.EventHandler(this.btnxoasv_Click);
            // 
            // blingsc
            // 
            this.blingsc.CurrentChanged += new System.EventHandler(this.blingsc_CurrentChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 374);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blingsc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blingsv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnthem;
        private System.Windows.Forms.ToolStripButton btnsua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton btnsuasv;
        private System.Windows.Forms.ToolStripButton btnxoasv;
        private System.Windows.Forms.ToolStripButton btndelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMECLASS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLASS;
        private System.Windows.Forms.BindingSource blingsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIRSTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn LASTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn POB;
        private System.Windows.Forms.DataGridViewTextBoxColumn GT;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCLASS;
        private System.Windows.Forms.BindingSource blingsv;
    }
}

