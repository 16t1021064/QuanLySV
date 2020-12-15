namespace AppQLSV
{
    partial class Frmchitiet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnameclass = new System.Windows.Forms.TextBox();
            this.txtclass = new System.Windows.Forms.TextBox();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btndongy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phòng học:";
            // 
            // txtnameclass
            // 
            this.txtnameclass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnameclass.Location = new System.Drawing.Point(83, 10);
            this.txtnameclass.Name = "txtnameclass";
            this.txtnameclass.Size = new System.Drawing.Size(286, 20);
            this.txtnameclass.TabIndex = 1;
            // 
            // txtclass
            // 
            this.txtclass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtclass.Location = new System.Drawing.Point(83, 36);
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(286, 20);
            this.txtclass.TabIndex = 1;
            // 
            // btnboqua
            // 
            this.btnboqua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnboqua.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnboqua.Location = new System.Drawing.Point(294, 72);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(75, 23);
            this.btnboqua.TabIndex = 2;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            // 
            // btndongy
            // 
            this.btndongy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndongy.Location = new System.Drawing.Point(210, 72);
            this.btndongy.Name = "btndongy";
            this.btndongy.Size = new System.Drawing.Size(75, 23);
            this.btndongy.TabIndex = 2;
            this.btndongy.Text = "Đồng ý";
            this.btndongy.UseVisualStyleBackColor = true;
            this.btndongy.Click += new System.EventHandler(this.btndongy_Click);
            // 
            // Frmchitiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnboqua;
            this.ClientSize = new System.Drawing.Size(414, 115);
            this.ControlBox = false;
            this.Controls.Add(this.btndongy);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.txtclass);
            this.Controls.Add(this.txtnameclass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frmchitiet";
            this.Text = "Thêm/Sửa lớp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnameclass;
        private System.Windows.Forms.TextBox txtclass;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btndongy;
    }
}