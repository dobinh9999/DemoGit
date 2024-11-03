namespace lab4_bai2
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
			this.txtkq = new System.Windows.Forms.TextBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.btnoke = new System.Windows.Forms.Button();
			this.btnreset = new System.Windows.Forms.Button();
			this.ccbweb = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// txtkq
			// 
			this.txtkq.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txtkq.Location = new System.Drawing.Point(47, 105);
			this.txtkq.Multiline = true;
			this.txtkq.Name = "txtkq";
			this.txtkq.Size = new System.Drawing.Size(426, 85);
			this.txtkq.TabIndex = 8;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(43, 25);
			this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(123, 20);
			this.linkLabel1.TabIndex = 4;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Liên kết website";
			// 
			// btnoke
			// 
			this.btnoke.Location = new System.Drawing.Point(249, 55);
			this.btnoke.Name = "btnoke";
			this.btnoke.Size = new System.Drawing.Size(112, 32);
			this.btnoke.TabIndex = 7;
			this.btnoke.Text = "Ok";
			this.btnoke.UseVisualStyleBackColor = true;
			this.btnoke.Click += new System.EventHandler(this.btnoke_Click);
			// 
			// btnreset
			// 
			this.btnreset.Location = new System.Drawing.Point(367, 55);
			this.btnreset.Name = "btnreset";
			this.btnreset.Size = new System.Drawing.Size(106, 32);
			this.btnreset.TabIndex = 6;
			this.btnreset.Text = "Reset";
			this.btnreset.UseVisualStyleBackColor = true;
			this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
			// 
			// ccbweb
			// 
			this.ccbweb.FormattingEnabled = true;
			this.ccbweb.Items.AddRange(new object[] {
            "Tuổi trẻ",
            "Thanh niên",
            "VNExpress",
            "Dân trí",
            "Quân đội"});
			this.ccbweb.Location = new System.Drawing.Point(47, 59);
			this.ccbweb.Name = "ccbweb";
			this.ccbweb.Size = new System.Drawing.Size(185, 28);
			this.ccbweb.TabIndex = 9;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(515, 220);
			this.Controls.Add(this.ccbweb);
			this.Controls.Add(this.txtkq);
			this.Controls.Add(this.btnreset);
			this.Controls.Add(this.btnoke);
			this.Controls.Add(this.linkLabel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtkq;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Button btnoke;
		private System.Windows.Forms.Button btnreset;
		private System.Windows.Forms.ComboBox ccbweb;
	}
}

