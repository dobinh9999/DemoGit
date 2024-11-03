namespace lab3_btvn_bai2
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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.btnchuyenhauto = new System.Windows.Forms.Button();
			this.btnthoat = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(53, 19);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(463, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "CHUYỂN BIỂU THỨC TRUNG TỐ ĐẦY ĐỦ DẤU NGOẶC\r\n                              SANG DẠ" +
    "NG HẬU TỐ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(53, 95);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(175, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Nhập biểu thức trung tố";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(53, 336);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Biểu thức hậu tố";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(57, 129);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(459, 96);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "";
			this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(57, 371);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(459, 109);
			this.richTextBox2.TabIndex = 2;
			this.richTextBox2.Text = "";
			// 
			// btnchuyenhauto
			// 
			this.btnchuyenhauto.Location = new System.Drawing.Point(110, 252);
			this.btnchuyenhauto.Name = "btnchuyenhauto";
			this.btnchuyenhauto.Size = new System.Drawing.Size(134, 39);
			this.btnchuyenhauto.TabIndex = 3;
			this.btnchuyenhauto.Text = "chuyển hậu tố";
			this.btnchuyenhauto.UseVisualStyleBackColor = true;
			this.btnchuyenhauto.Click += new System.EventHandler(this.btnchuyenhauto_Click);
			// 
			// btnthoat
			// 
			this.btnthoat.Location = new System.Drawing.Point(344, 263);
			this.btnthoat.Name = "btnthoat";
			this.btnthoat.Size = new System.Drawing.Size(134, 39);
			this.btnthoat.TabIndex = 3;
			this.btnthoat.Text = "thoát";
			this.btnthoat.UseVisualStyleBackColor = true;
			this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(591, 492);
			this.Controls.Add(this.btnthoat);
			this.Controls.Add(this.btnchuyenhauto);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "                                                          Chuyển trung tố về hậu " +
    "tố";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.Button btnchuyenhauto;
		private System.Windows.Forms.Button btnthoat;
	}
}

