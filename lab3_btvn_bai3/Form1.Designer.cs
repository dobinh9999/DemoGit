namespace lab3_btvn_bai3
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
			this.txtN = new System.Windows.Forms.TextBox();
			this.btntinhtong = new System.Windows.Forms.Button();
			this.btnsnt = new System.Windows.Forms.Button();
			this.rtb_kq = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(54, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhập n:";
			// 
			// txtN
			// 
			this.txtN.Location = new System.Drawing.Point(185, 33);
			this.txtN.Name = "txtN";
			this.txtN.Size = new System.Drawing.Size(292, 26);
			this.txtN.TabIndex = 1;
			// 
			// btntinhtong
			// 
			this.btntinhtong.Location = new System.Drawing.Point(58, 119);
			this.btntinhtong.Name = "btntinhtong";
			this.btntinhtong.Size = new System.Drawing.Size(159, 41);
			this.btntinhtong.TabIndex = 2;
			this.btntinhtong.Text = "Tính Tổng";
			this.btntinhtong.UseVisualStyleBackColor = true;
			this.btntinhtong.Click += new System.EventHandler(this.btntinhtong_Click);
			// 
			// btnsnt
			// 
			this.btnsnt.Location = new System.Drawing.Point(58, 205);
			this.btnsnt.Name = "btnsnt";
			this.btnsnt.Size = new System.Drawing.Size(159, 41);
			this.btnsnt.TabIndex = 2;
			this.btnsnt.Text = "Kiểm Tra Nguyên Tố";
			this.btnsnt.UseVisualStyleBackColor = true;
			this.btnsnt.Click += new System.EventHandler(this.btnsnt_Click);
			// 
			// rtb_kq
			// 
			this.rtb_kq.Location = new System.Drawing.Point(246, 119);
			this.rtb_kq.Name = "rtb_kq";
			this.rtb_kq.Size = new System.Drawing.Size(231, 118);
			this.rtb_kq.TabIndex = 3;
			this.rtb_kq.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(512, 276);
			this.Controls.Add(this.rtb_kq);
			this.Controls.Add(this.btnsnt);
			this.Controls.Add(this.btntinhtong);
			this.Controls.Add(this.txtN);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtN;
		private System.Windows.Forms.Button btntinhtong;
		private System.Windows.Forms.Button btnsnt;
		private System.Windows.Forms.RichTextBox rtb_kq;
	}
}

