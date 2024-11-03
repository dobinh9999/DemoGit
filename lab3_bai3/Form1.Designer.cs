namespace lab3_bai3
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.gr_tinh = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.btnnhap = new System.Windows.Forms.Button();
			this.btnthoat = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.rdo_tinhdientich = new System.Windows.Forms.RadioButton();
			this.rdo_tinhchuci = new System.Windows.Forms.RadioButton();
			this.lblKq = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.gr_tinh.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(89, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(329, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "TÍNH CHU VI VÀ DIỆN TÍCH TAM GIÁC";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnthoat);
			this.groupBox1.Controls.Add(this.btnnhap);
			this.groupBox1.Controls.Add(this.txt3);
			this.groupBox1.Controls.Add(this.txt2);
			this.groupBox1.Controls.Add(this.txt1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 78);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(500, 248);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nhập dữ liệu";
			// 
			// gr_tinh
			// 
			this.gr_tinh.Controls.Add(this.rdo_tinhchuci);
			this.gr_tinh.Controls.Add(this.rdo_tinhdientich);
			this.gr_tinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gr_tinh.Location = new System.Drawing.Point(12, 332);
			this.gr_tinh.Name = "gr_tinh";
			this.gr_tinh.Size = new System.Drawing.Size(500, 136);
			this.gr_tinh.TabIndex = 1;
			this.gr_tinh.TabStop = false;
			this.gr_tinh.Text = "Tính";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(37, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Nhập cạnh thứ 1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(37, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Nhập cạnh thứ 2";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(37, 178);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(126, 20);
			this.label4.TabIndex = 0;
			this.label4.Text = "Nhập cạnh thứ 3";
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(205, 48);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(100, 26);
			this.txt1.TabIndex = 1;
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(205, 114);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(100, 26);
			this.txt2.TabIndex = 1;
			// 
			// txt3
			// 
			this.txt3.Location = new System.Drawing.Point(205, 172);
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(100, 26);
			this.txt3.TabIndex = 1;
			// 
			// btnnhap
			// 
			this.btnnhap.Location = new System.Drawing.Point(365, 77);
			this.btnnhap.Name = "btnnhap";
			this.btnnhap.Size = new System.Drawing.Size(85, 32);
			this.btnnhap.TabIndex = 2;
			this.btnnhap.Text = "Nhập";
			this.btnnhap.UseVisualStyleBackColor = true;
			this.btnnhap.Click += new System.EventHandler(this.btnnhap_Click);
			// 
			// btnthoat
			// 
			this.btnthoat.Location = new System.Drawing.Point(365, 143);
			this.btnthoat.Name = "btnthoat";
			this.btnthoat.Size = new System.Drawing.Size(85, 32);
			this.btnthoat.TabIndex = 2;
			this.btnthoat.Text = "Thoát";
			this.btnthoat.UseVisualStyleBackColor = true;
			this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
			// 
			// rdo_tinhdientich
			// 
			this.rdo_tinhdientich.AutoSize = true;
			this.rdo_tinhdientich.Location = new System.Drawing.Point(67, 36);
			this.rdo_tinhdientich.Name = "rdo_tinhdientich";
			this.rdo_tinhdientich.Size = new System.Drawing.Size(153, 24);
			this.rdo_tinhdientich.TabIndex = 0;
			this.rdo_tinhdientich.TabStop = true;
			this.rdo_tinhdientich.Text = "Diện tích tam giác";
			this.rdo_tinhdientich.UseVisualStyleBackColor = true;
			this.rdo_tinhdientich.CheckedChanged += new System.EventHandler(this.rdo_tinhdientich_CheckedChanged);
			// 
			// rdo_tinhchuci
			// 
			this.rdo_tinhchuci.AutoSize = true;
			this.rdo_tinhchuci.Location = new System.Drawing.Point(67, 88);
			this.rdo_tinhchuci.Name = "rdo_tinhchuci";
			this.rdo_tinhchuci.Size = new System.Drawing.Size(134, 24);
			this.rdo_tinhchuci.TabIndex = 0;
			this.rdo_tinhchuci.TabStop = true;
			this.rdo_tinhchuci.Text = "Chu vi tam giác";
			this.rdo_tinhchuci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rdo_tinhchuci.UseVisualStyleBackColor = true;
			this.rdo_tinhchuci.CheckedChanged += new System.EventHandler(this.rdo_tinhchuci_CheckedChanged);
			// 
			// lblKq
			// 
			this.lblKq.AutoSize = true;
			this.lblKq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblKq.Location = new System.Drawing.Point(43, 482);
			this.lblKq.Name = "lblKq";
			this.lblKq.Size = new System.Drawing.Size(102, 25);
			this.lblKq.TabIndex = 0;
			this.lblKq.Text = "Kết Quả :";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(524, 516);
			this.Controls.Add(this.gr_tinh);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblKq);
			this.Name = "Form1";
			this.Text = "                                      bài 3: Tính diện tích và chu vi tam giác";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gr_tinh.ResumeLayout(false);
			this.gr_tinh.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnthoat;
		private System.Windows.Forms.Button btnnhap;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox gr_tinh;
		private System.Windows.Forms.RadioButton rdo_tinhchuci;
		private System.Windows.Forms.RadioButton rdo_tinhdientich;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label lblKq;
	}
}

