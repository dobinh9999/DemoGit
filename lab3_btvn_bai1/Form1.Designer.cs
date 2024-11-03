namespace lab3_btvn_bai1
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
			this.btnkt = new System.Windows.Forms.Button();
			this.txtA = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtB = new System.Windows.Forms.TextBox();
			this.btngpt = new System.Windows.Forms.Button();
			this.lblKq = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(73, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(277, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bất phương trình ax+b <0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(65, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nhập a:";
			// 
			// btnkt
			// 
			this.btnkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnkt.Location = new System.Drawing.Point(69, 206);
			this.btnkt.Name = "btnkt";
			this.btnkt.Size = new System.Drawing.Size(92, 29);
			this.btnkt.TabIndex = 2;
			this.btnkt.Text = "kiểm tra";
			this.btnkt.UseVisualStyleBackColor = true;
			this.btnkt.Click += new System.EventHandler(this.btnkt_Click);
			// 
			// txtA
			// 
			this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtA.Location = new System.Drawing.Point(166, 70);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(152, 26);
			this.txtA.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(65, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 20);
			this.label3.TabIndex = 1;
			this.label3.Text = "Nhập b:";
			// 
			// txtB
			// 
			this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtB.Location = new System.Drawing.Point(166, 116);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(152, 26);
			this.txtB.TabIndex = 3;
			// 
			// btngpt
			// 
			this.btngpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btngpt.Location = new System.Drawing.Point(167, 206);
			this.btngpt.Name = "btngpt";
			this.btngpt.Size = new System.Drawing.Size(151, 29);
			this.btngpt.TabIndex = 2;
			this.btngpt.Text = "Giải phương trình";
			this.btngpt.UseVisualStyleBackColor = true;
			this.btngpt.Click += new System.EventHandler(this.btngpt_Click);
			// 
			// lblKq
			// 
			this.lblKq.AutoSize = true;
			this.lblKq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblKq.Location = new System.Drawing.Point(65, 166);
			this.lblKq.Name = "lblKq";
			this.lblKq.Size = new System.Drawing.Size(68, 20);
			this.lblKq.TabIndex = 1;
			this.lblKq.Text = "Kết quả:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(445, 247);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.lblKq);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btngpt);
			this.Controls.Add(this.btnkt);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "giải bất phương trình";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnkt;
		private System.Windows.Forms.TextBox txtA;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.Button btngpt;
		private System.Windows.Forms.Label lblKq;
	}
}

