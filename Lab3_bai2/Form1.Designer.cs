namespace Lab3_bai2
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
			this.label3 = new System.Windows.Forms.Label();
			this.txtnhap1 = new System.Windows.Forms.TextBox();
			this.btnTimucln = new System.Windows.Forms.Button();
			this.btnTimbcnn = new System.Windows.Forms.Button();
			this.txtnhap2 = new System.Windows.Forms.TextBox();
			this.txtkqLN = new System.Windows.Forms.TextBox();
			this.txtkqNN = new System.Windows.Forms.TextBox();
			this.btnnhap = new System.Windows.Forms.Button();
			this.btnthoat = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(99, 24);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(277, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Chương Trình Tìm UCLN và BCNN";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 96);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Nhập số thứ nhất";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 162);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Nhập số thứ hai";
			// 
			// txtnhap1
			// 
			this.txtnhap1.Location = new System.Drawing.Point(151, 91);
			this.txtnhap1.Name = "txtnhap1";
			this.txtnhap1.Size = new System.Drawing.Size(100, 26);
			this.txtnhap1.TabIndex = 1;
			// 
			// btnTimucln
			// 
			this.btnTimucln.Location = new System.Drawing.Point(257, 89);
			this.btnTimucln.Name = "btnTimucln";
			this.btnTimucln.Size = new System.Drawing.Size(92, 30);
			this.btnTimucln.TabIndex = 2;
			this.btnTimucln.Text = "Tìm UCLN";
			this.btnTimucln.UseVisualStyleBackColor = true;
			this.btnTimucln.Click += new System.EventHandler(this.btnTimucln_Click);
			// 
			// btnTimbcnn
			// 
			this.btnTimbcnn.Location = new System.Drawing.Point(257, 157);
			this.btnTimbcnn.Name = "btnTimbcnn";
			this.btnTimbcnn.Size = new System.Drawing.Size(95, 30);
			this.btnTimbcnn.TabIndex = 2;
			this.btnTimbcnn.Text = "Tìm BCNN";
			this.btnTimbcnn.UseVisualStyleBackColor = true;
			this.btnTimbcnn.Click += new System.EventHandler(this.btnTimbcnn_Click);
			// 
			// txtnhap2
			// 
			this.txtnhap2.Location = new System.Drawing.Point(151, 159);
			this.txtnhap2.Name = "txtnhap2";
			this.txtnhap2.Size = new System.Drawing.Size(100, 26);
			this.txtnhap2.TabIndex = 1;
			// 
			// txtkqLN
			// 
			this.txtkqLN.Location = new System.Drawing.Point(366, 91);
			this.txtkqLN.Name = "txtkqLN";
			this.txtkqLN.Size = new System.Drawing.Size(100, 26);
			this.txtkqLN.TabIndex = 1;
			// 
			// txtkqNN
			// 
			this.txtkqNN.Location = new System.Drawing.Point(366, 159);
			this.txtkqNN.Name = "txtkqNN";
			this.txtkqNN.Size = new System.Drawing.Size(100, 26);
			this.txtkqNN.TabIndex = 1;
			// 
			// btnnhap
			// 
			this.btnnhap.Location = new System.Drawing.Point(21, 214);
			this.btnnhap.Name = "btnnhap";
			this.btnnhap.Size = new System.Drawing.Size(95, 30);
			this.btnnhap.TabIndex = 2;
			this.btnnhap.Text = "Nhập";
			this.btnnhap.UseVisualStyleBackColor = true;
			this.btnnhap.Click += new System.EventHandler(this.btnnhap_Click);
			// 
			// btnthoat
			// 
			this.btnthoat.Location = new System.Drawing.Point(151, 214);
			this.btnthoat.Name = "btnthoat";
			this.btnthoat.Size = new System.Drawing.Size(95, 30);
			this.btnthoat.TabIndex = 2;
			this.btnthoat.Text = "Thoát";
			this.btnthoat.UseVisualStyleBackColor = true;
			this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(478, 268);
			this.Controls.Add(this.btnthoat);
			this.Controls.Add(this.btnnhap);
			this.Controls.Add(this.btnTimbcnn);
			this.Controls.Add(this.btnTimucln);
			this.Controls.Add(this.txtkqNN);
			this.Controls.Add(this.txtnhap2);
			this.Controls.Add(this.txtkqLN);
			this.Controls.Add(this.txtnhap1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "                                     Bài 2 : Tìm UCLN và BCNN";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtnhap1;
		private System.Windows.Forms.Button btnTimucln;
		private System.Windows.Forms.Button btnTimbcnn;
		private System.Windows.Forms.TextBox txtnhap2;
		private System.Windows.Forms.TextBox txtkqLN;
		private System.Windows.Forms.TextBox txtkqNN;
		private System.Windows.Forms.Button btnnhap;
		private System.Windows.Forms.Button btnthoat;
	}
}

