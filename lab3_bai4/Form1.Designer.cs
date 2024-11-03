namespace lab3_bai4
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
			this.label2 = new System.Windows.Forms.Label();
			this.gr_luachon = new System.Windows.Forms.GroupBox();
			this.lblkq = new System.Windows.Forms.Label();
			this.rdotinhtongN = new System.Windows.Forms.RadioButton();
			this.rdopheptinhtong = new System.Windows.Forms.RadioButton();
			this.gr_luachon.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(100, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tính Tổng";
			// 
			// txtN
			// 
			this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtN.Location = new System.Drawing.Point(142, 86);
			this.txtN.Name = "txtN";
			this.txtN.Size = new System.Drawing.Size(197, 26);
			this.txtN.TabIndex = 1;
			this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(42, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Nhập n";
			// 
			// gr_luachon
			// 
			this.gr_luachon.Controls.Add(this.rdopheptinhtong);
			this.gr_luachon.Controls.Add(this.rdotinhtongN);
			this.gr_luachon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gr_luachon.Location = new System.Drawing.Point(13, 144);
			this.gr_luachon.Name = "gr_luachon";
			this.gr_luachon.Size = new System.Drawing.Size(326, 182);
			this.gr_luachon.TabIndex = 2;
			this.gr_luachon.TabStop = false;
			this.gr_luachon.Text = "Lựa chọn";
			// 
			// lblkq
			// 
			this.lblkq.AutoSize = true;
			this.lblkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblkq.Location = new System.Drawing.Point(42, 350);
			this.lblkq.Name = "lblkq";
			this.lblkq.Size = new System.Drawing.Size(64, 20);
			this.lblkq.TabIndex = 0;
			this.lblkq.Text = "Kết quả";
			// 
			// rdotinhtongN
			// 
			this.rdotinhtongN.AutoSize = true;
			this.rdotinhtongN.Location = new System.Drawing.Point(33, 51);
			this.rdotinhtongN.Name = "rdotinhtongN";
			this.rdotinhtongN.Size = new System.Drawing.Size(220, 24);
			this.rdotinhtongN.TabIndex = 0;
			this.rdotinhtongN.TabStop = true;
			this.rdotinhtongN.Text = "Tính Tổng các chữ số của n";
			this.rdotinhtongN.UseVisualStyleBackColor = true;
			this.rdotinhtongN.CheckedChanged += new System.EventHandler(this.rdotinhtongN_CheckedChanged);
			// 
			// rdopheptinhtong
			// 
			this.rdopheptinhtong.AutoSize = true;
			this.rdopheptinhtong.Location = new System.Drawing.Point(33, 118);
			this.rdopheptinhtong.Name = "rdopheptinhtong";
			this.rdopheptinhtong.Size = new System.Drawing.Size(244, 24);
			this.rdopheptinhtong.TabIndex = 0;
			this.rdopheptinhtong.TabStop = true;
			this.rdopheptinhtong.Text = "Tính tổng 1+ 1/2 + 1/3 + ...+ 1/n";
			this.rdopheptinhtong.UseVisualStyleBackColor = true;
			this.rdopheptinhtong.CheckedChanged += new System.EventHandler(this.rdopheptinhtong_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(361, 392);
			this.Controls.Add(this.gr_luachon);
			this.Controls.Add(this.txtN);
			this.Controls.Add(this.lblkq);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "                                bài 4 : Tính Tổng";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.gr_luachon.ResumeLayout(false);
			this.gr_luachon.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtN;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox gr_luachon;
		private System.Windows.Forms.RadioButton rdopheptinhtong;
		private System.Windows.Forms.RadioButton rdotinhtongN;
		private System.Windows.Forms.Label lblkq;
	}
}

