namespace lab4_bai3
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtten = new System.Windows.Forms.TextBox();
			this.btncapnhat = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lstA = new System.Windows.Forms.ListBox();
			this.btnxoa = new System.Windows.Forms.Button();
			this.btnketthuc = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lstB = new System.Windows.Forms.ListBox();
			this.btncphai = new System.Windows.Forms.Button();
			this.btnctrai = new System.Windows.Forms.Button();
			this.btnallphai = new System.Windows.Forms.Button();
			this.btnalltrai = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(133, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(238, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "DANH SACH SINH VIÊN";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(50, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Họ và tên";
			// 
			// txtten
			// 
			this.txtten.Location = new System.Drawing.Point(137, 78);
			this.txtten.Name = "txtten";
			this.txtten.Size = new System.Drawing.Size(234, 26);
			this.txtten.TabIndex = 1;
			// 
			// btncapnhat
			// 
			this.btncapnhat.Location = new System.Drawing.Point(377, 78);
			this.btncapnhat.Name = "btncapnhat";
			this.btncapnhat.Size = new System.Drawing.Size(94, 26);
			this.btncapnhat.TabIndex = 2;
			this.btncapnhat.Text = "cập nhật";
			this.btncapnhat.UseVisualStyleBackColor = true;
			this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lstA);
			this.groupBox1.Location = new System.Drawing.Point(12, 124);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(178, 197);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Lớp A";
			// 
			// lstA
			// 
			this.lstA.FormattingEnabled = true;
			this.lstA.ItemHeight = 20;
			this.lstA.Items.AddRange(new object[] {
            "Huỳnh Phương Anh",
            "Lưu Tấn Đức",
            "Trần Anh Khoa",
            "Lê Hoàng Hà",
            "Phan Anh Hào"});
			this.lstA.Location = new System.Drawing.Point(7, 26);
			this.lstA.Name = "lstA";
			this.lstA.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.lstA.Size = new System.Drawing.Size(165, 164);
			this.lstA.TabIndex = 0;
			this.lstA.SelectedIndexChanged += new System.EventHandler(this.lstA_SelectedIndexChanged);
			// 
			// btnxoa
			// 
			this.btnxoa.Location = new System.Drawing.Point(42, 327);
			this.btnxoa.Name = "btnxoa";
			this.btnxoa.Size = new System.Drawing.Size(94, 26);
			this.btnxoa.TabIndex = 2;
			this.btnxoa.Text = "xóa";
			this.btnxoa.UseVisualStyleBackColor = true;
			this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
			// 
			// btnketthuc
			// 
			this.btnketthuc.Location = new System.Drawing.Point(377, 327);
			this.btnketthuc.Name = "btnketthuc";
			this.btnketthuc.Size = new System.Drawing.Size(94, 26);
			this.btnketthuc.TabIndex = 2;
			this.btnketthuc.Text = "kết thúc";
			this.btnketthuc.UseVisualStyleBackColor = true;
			this.btnketthuc.Click += new System.EventHandler(this.btnketthuc_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lstB);
			this.groupBox2.Location = new System.Drawing.Point(317, 124);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(182, 197);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Lớp B";
			// 
			// lstB
			// 
			this.lstB.FormattingEnabled = true;
			this.lstB.ItemHeight = 20;
			this.lstB.Items.AddRange(new object[] {
            "Hoàng Hồ Nam",
            "Lê Anh Trung"});
			this.lstB.Location = new System.Drawing.Point(6, 26);
			this.lstB.Name = "lstB";
			this.lstB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.lstB.Size = new System.Drawing.Size(170, 164);
			this.lstB.TabIndex = 0;
			this.lstB.SelectedIndexChanged += new System.EventHandler(this.lstB_SelectedIndexChanged);
			// 
			// btncphai
			// 
			this.btncphai.Location = new System.Drawing.Point(196, 167);
			this.btncphai.Name = "btncphai";
			this.btncphai.Size = new System.Drawing.Size(50, 26);
			this.btncphai.TabIndex = 2;
			this.btncphai.Text = ">";
			this.btncphai.UseVisualStyleBackColor = true;
			this.btncphai.Click += new System.EventHandler(this.btncphai_Click);
			// 
			// btnctrai
			// 
			this.btnctrai.Location = new System.Drawing.Point(261, 167);
			this.btnctrai.Name = "btnctrai";
			this.btnctrai.Size = new System.Drawing.Size(50, 26);
			this.btnctrai.TabIndex = 2;
			this.btnctrai.Text = "<";
			this.btnctrai.UseVisualStyleBackColor = true;
			this.btnctrai.Click += new System.EventHandler(this.btnctrai_Click);
			// 
			// btnallphai
			// 
			this.btnallphai.Location = new System.Drawing.Point(196, 220);
			this.btnallphai.Name = "btnallphai";
			this.btnallphai.Size = new System.Drawing.Size(50, 26);
			this.btnallphai.TabIndex = 2;
			this.btnallphai.Text = ">>";
			this.btnallphai.UseVisualStyleBackColor = true;
			this.btnallphai.Click += new System.EventHandler(this.btnallphai_Click);
			// 
			// btnalltrai
			// 
			this.btnalltrai.Location = new System.Drawing.Point(261, 220);
			this.btnalltrai.Name = "btnalltrai";
			this.btnalltrai.Size = new System.Drawing.Size(50, 26);
			this.btnalltrai.TabIndex = 2;
			this.btnalltrai.Text = "<<";
			this.btnalltrai.UseVisualStyleBackColor = true;
			this.btnalltrai.Click += new System.EventHandler(this.btnalltrai_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(511, 365);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnketthuc);
			this.Controls.Add(this.btnalltrai);
			this.Controls.Add(this.btnctrai);
			this.Controls.Add(this.btnallphai);
			this.Controls.Add(this.btncphai);
			this.Controls.Add(this.btnxoa);
			this.Controls.Add(this.btncapnhat);
			this.Controls.Add(this.txtten);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtten;
		private System.Windows.Forms.Button btncapnhat;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnxoa;
		private System.Windows.Forms.Button btnketthuc;
		private System.Windows.Forms.ListBox lstA;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListBox lstB;
		private System.Windows.Forms.Button btncphai;
		private System.Windows.Forms.Button btnctrai;
		private System.Windows.Forms.Button btnallphai;
		private System.Windows.Forms.Button btnalltrai;
	}
}

