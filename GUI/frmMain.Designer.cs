
using System;

namespace AppQLSV
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.gridLopHoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnXoaLop = new System.Windows.Forms.ToolStripButton();
            this.btnSuaLop = new System.Windows.Forms.ToolStripButton();
            this.btnThemLop = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnXoaSinhVien = new System.Windows.Forms.ToolStripButton();
            this.btnSuaSinhVien = new System.Windows.Forms.ToolStripButton();
            this.btnThemSinhVien = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.bdsLopHoc = new System.Windows.Forms.BindingSource(this.components);
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLopHoc)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.gridLopHoc);
            this.panelLeft.Controls.Add(this.toolStrip1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(289, 450);
            this.panelLeft.TabIndex = 0;
            // 
            // gridLopHoc
            // 
            this.gridLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.gridLopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLopHoc.Location = new System.Drawing.Point(0, 25);
            this.gridLopHoc.Name = "gridLopHoc";
            this.gridLopHoc.Size = new System.Drawing.Size(289, 425);
            this.gridLopHoc.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Tên lớp";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Room";
            this.Column2.HeaderText = "Phòng học";
            this.Column2.Name = "Column2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnXoaLop,
            this.btnSuaLop,
            this.btnThemLop});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(289, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(105, 22);
            this.toolStripLabel1.Text = "Danh sách lớp học";
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoaLop.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaLop.Image")));
            this.btnXoaLop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(47, 22);
            this.btnXoaLop.Text = "Xóa";
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSuaLop.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaLop.Image")));
            this.btnSuaLop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new System.Drawing.Size(46, 22);
            this.btnSuaLop.Text = "Sửa";
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);
            // 
            // btnThemLop
            // 
            this.btnThemLop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnThemLop.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLop.Image")));
            this.btnThemLop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(57, 22);
            this.btnThemLop.Text = "Thêm";
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(289, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 450);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(580, 425);
            this.dataGridView2.TabIndex = 0;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ID";
            this.Column3.HeaderText = "Mã sinh viên";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "FirstName";
            this.Column4.HeaderText = "Họ";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "LastName";
            this.Column5.HeaderText = "Tên";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DateOfBirth";
            this.Column6.HeaderText = "Ngày sinh";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "PlaceOfBirth";
            this.Column7.HeaderText = "Nơi sinh";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Gender";
            this.Column8.HeaderText = "GT";
            this.Column8.Name = "Column8";
            this.Column8.Width = 50;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnXoaSinhVien,
            this.btnSuaSinhVien,
            this.btnThemSinhVien,
            this.toolStripLabel2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(580, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnXoaSinhVien
            // 
            this.btnXoaSinhVien.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoaSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaSinhVien.Image")));
            this.btnXoaSinhVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaSinhVien.Name = "btnXoaSinhVien";
            this.btnXoaSinhVien.Size = new System.Drawing.Size(47, 22);
            this.btnXoaSinhVien.Text = "Xóa";
            this.btnXoaSinhVien.Click += new System.EventHandler(this.btnXoaSinhVien_Click);
            // 
            // btnSuaSinhVien
            // 
            this.btnSuaSinhVien.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSuaSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaSinhVien.Image")));
            this.btnSuaSinhVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaSinhVien.Name = "btnSuaSinhVien";
            this.btnSuaSinhVien.Size = new System.Drawing.Size(46, 22);
            this.btnSuaSinhVien.Text = "Sửa";
            this.btnSuaSinhVien.Click += new System.EventHandler(this.btnSuaSinhVien_Click);
            // 
            // btnThemSinhVien
            // 
            this.btnThemSinhVien.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnThemSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSinhVien.Image")));
            this.btnThemSinhVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemSinhVien.Name = "btnThemSinhVien";
            this.btnThemSinhVien.Size = new System.Drawing.Size(57, 22);
            this.btnThemSinhVien.Text = "Thêm";
            this.btnThemSinhVien.Click += new System.EventHandler(this.btnThemSinhVien_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(112, 22);
            this.toolStripLabel2.Text = "Danh sách sinh viên";
            // 
            // bdsLopHoc
            // 
            this.bdsLopHoc.CurrentChanged += new System.EventHandler(this.bdsLopHoc_CurrentChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLeft);
            this.Name = "FormMain";
            this.Text = "Quản lý sinh viên";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLopHoc)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.DataGridView gridLopHoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnXoaLop;
        private System.Windows.Forms.ToolStripButton btnSuaLop;
        private System.Windows.Forms.ToolStripButton btnThemLop;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnXoaSinhVien;
        private System.Windows.Forms.ToolStripButton btnSuaSinhVien;
        private System.Windows.Forms.ToolStripButton btnThemSinhVien;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.BindingSource bdsLopHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.BindingSource bdsSinhVien;
    }
}

